﻿using CalculateFunding.Common.ApiClient.Models;
using Newtonsoft.Json;

namespace CalculateFunding.Common.ApiClient.Calcs.Models
{

    public class CalculationVersion : VersionedItem
    {
        [JsonProperty("id")]
        public override string Id => $"{CalculationId}_version_{Version}";
       
        [JsonProperty("entityId")]
        public override string EntityId
        {
            get { return $"{CalculationId}"; }
        }

        [JsonProperty("sourceCode")]
        public string SourceCode { get; set; }

        [JsonProperty("calculationId")]
        public string CalculationId { get; set; }

        [JsonProperty("calculationType")]
        public CalculationType CalculationType { get; set; }

        [JsonProperty("sourceCodeName")]
        public string SourceCodeName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public CalculationNamespace Namespace { get; set; }

        [JsonProperty("wasTemplateCalculation")]
        public bool WasTemplateCalculation { get; set; }

        [JsonProperty("valueType")]
        public CalculationValueType ValueType { get; set; }

        /// <summary>
        /// Used for putting description in the built assembly, this gets populated only when being called from this scenario.
        /// This value shouldn't be stored in CosmosDB
        /// The same models are used for persistance and input to the calculation engine
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        public override VersionedItem Clone()
        {
            return new CalculationVersion
            {
                PublishStatus = PublishStatus,
                Version = Version,
                SourceCode = SourceCode,
                Date = Date,
                Author = Author,
                Comment = Comment,
                CalculationId = CalculationId,
                SourceCodeName = SourceCodeName,
                CalculationType = CalculationType,
                Namespace = Namespace,
                WasTemplateCalculation = WasTemplateCalculation,
                ValueType = ValueType,
                Name = Name
            };
        }
    }
}