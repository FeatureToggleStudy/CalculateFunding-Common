﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CalculateFunding.Common.ApiClient.Interfaces;
using CalculateFunding.Common.ApiClient.Models;
using CalculateFunding.Common.ApiClient.Users.Models;
using CalculateFunding.Common.FeatureToggles;
using CalculateFunding.Common.Identity.Authorization.Models;
using CalculateFunding.Common.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace CalculateFunding.Common.Identity.Authorization
{
    public class FundingStreamPermissionHandler : AuthorizationHandler<FundingStreamRequirement, IEnumerable<string>>
    {
        private readonly IUsersApiClient _usersApiClient;
        private readonly PermissionOptions _permissionOptions;
        private readonly IFeatureToggle _features;

        public FundingStreamPermissionHandler(IUsersApiClient usersApiClient, IOptions<PermissionOptions> permissionOptions, IFeatureToggle features)
        {
            Guard.ArgumentNotNull(usersApiClient, nameof(usersApiClient));
            Guard.ArgumentNotNull(permissionOptions, nameof(permissionOptions));
            Guard.ArgumentNotNull(features, nameof(features));

            _usersApiClient = usersApiClient;
            _permissionOptions = permissionOptions.Value;
            _features = features;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, FundingStreamRequirement requirement, IEnumerable<string> resource)
        {
            if (!_features.IsRoleBasedAccessEnabled())
            {
                context.Succeed(requirement);
                return;
            }

            // If user belongs to the admin group then allow them access
            if (context.User.HasClaim(c => c.Type == Constants.GroupsClaimType && c.Value.ToLowerInvariant() == _permissionOptions.AdminGroupId.ToString().ToLowerInvariant()))
            {
                context.Succeed(requirement);
            }
            else
            {
                // Get user permissions for funding stream
                if (context.User.HasClaim(c => c.Type == Constants.ObjectIdentifierClaimType))
                {
                    string userId = context.User.FindFirst(Constants.ObjectIdentifierClaimType).Value;
                    ApiResponse<IEnumerable<FundingStreamPermission>> permissionsResponse = await _usersApiClient.GetFundingStreamPermissionsForUser(userId);

                    if (permissionsResponse == null || permissionsResponse.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Error calling the permissions service - {permissionsResponse.StatusCode}");
                    }

                    // Check user has permissions for funding stream
                    if (HasPermissionToAllFundingStreams(resource, requirement.ActionType, permissionsResponse.Content))
                    {
                        context.Succeed(requirement);
                    }
                }
            }
        }

        private bool HasPermissionToAllFundingStreams(IEnumerable<string> fundingStreamIds, FundingStreamActionTypes requestedPermission, IEnumerable<FundingStreamPermission> actualPermissions)
        {
            if (actualPermissions == null || actualPermissions.Count() == 0)
            {
                // No permissions to check against so can't have permission for the action
                return false;
            }

            if (requestedPermission == FundingStreamActionTypes.CanCreateSpecification)
            {
                foreach (string item in fundingStreamIds)
                {
                    FundingStreamPermission foundPermission = actualPermissions.FirstOrDefault(p => p.FundingStreamId == item && p.CanCreateSpecification);

                    if (foundPermission == null)
                    {
                        // A required permission is missing so can't succeed
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
