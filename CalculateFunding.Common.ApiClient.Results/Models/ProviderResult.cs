using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CalculateFunding.Common.ApiClient.Results.Models
{
    public class ProviderResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("specificationId")]
        public string SpecificationId { get; set; }

        [JsonProperty("provider")]
        public ProviderSummary Provider { get; set; }

        [JsonProperty("calcResults")]
        public List<CalculationResult> CalculationResults { get; set; }
    }
}