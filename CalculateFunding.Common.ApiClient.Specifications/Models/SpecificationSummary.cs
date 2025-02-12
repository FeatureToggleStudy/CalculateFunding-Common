﻿using System.Collections.Generic;
using CalculateFunding.Common.ApiClient.Models;
using CalculateFunding.Common.Identity.Authorization.Models;
using CalculateFunding.Common.Models;
using Newtonsoft.Json;

namespace CalculateFunding.Common.ApiClient.Specifications.Models
{
    public class SpecificationSummary : Reference, ISpecificationAuthorizationEntity
    {
        [JsonProperty("fundingPeriod")]
        public Reference FundingPeriod { get; set; }

        [JsonProperty("fundingStreams")]
        public IEnumerable<Reference> FundingStreams { get; set; }

        [JsonProperty("providerVersionId")]
        public string ProviderVersionId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isSelectedForFunding")]
        public bool IsSelectedForFunding { get; set; }

        [JsonProperty("approvalStatus")]
        public PublishStatus ApprovalStatus { get; set; }

        /// <summary>
        /// Assigned template versions for each funding stream in this specification.
        /// Key is the funding stream ID, value is the version of the funding template for that funding stream
        /// </summary>
        [JsonProperty("templateIds")]
        public IDictionary<string, string> TemplateIds { get; set; }

        public string GetSpecificationId()
        {
            return Id;
        }
    }
}