﻿using Newtonsoft.Json;

namespace CalculateFunding.Common.ApiClient.Users.Models
{
    public class FundingStreamPermission
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("fundingStreamId")]
        public string FundingStreamId { get; set; }

        [JsonProperty("canAdministerFundingStream")]
        public bool CanAdministerFundingStream { get; set; }

        [JsonProperty("canCreateSpecification")]
        public bool CanCreateSpecification { get; set; }

        [JsonProperty("canEditSpecification")]
        public bool CanEditSpecification { get; set; }

        [JsonProperty("canApproveSpecification")]
        public bool CanApproveSpecification { get; set; }

        [JsonProperty("canDeleteSpecification")]
        public bool CanDeleteSpecification { get; set; }

        [JsonProperty("canEditCalculations")]
        public bool CanEditCalculations { get; set; }

        [JsonProperty("canDeleteCalculations")]
        public bool CanDeleteCalculations { get; set; }

        [JsonProperty("canMapDatasets")]
        public bool CanMapDatasets { get; set; }

        [JsonProperty("canChooseFunding")]
        public bool CanChooseFunding { get; set; }

        [JsonProperty("canRefreshFunding")]
        public bool CanRefreshFunding { get; set; }

        [JsonProperty("canApproveFunding")]
        public bool CanApproveFunding { get; set; }

        [JsonProperty("canReleaseFunding")]
        public bool CanReleaseFunding { get; set; }

        [JsonProperty("canCreateQaTests")]
        public bool CanCreateQaTests { get; set; }

        [JsonProperty("canEditQaTests")]
        public bool CanEditQaTests { get; set; }

        [JsonProperty("canDeleteQaTests")]
        public bool CanDeleteQaTests { get; set; }
    }
}
