namespace CalculateFunding.Common.ApiClient.DataSets.Models
{
    public class CreateDefinitionSpecificationRelationshipModel
    {
        public string DatasetDefinitionId { get; set; }

        public string SpecificationId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsSetAsProviderData { get; set; }

        public bool UsedInDataAggregations { get; set; }
    }
}