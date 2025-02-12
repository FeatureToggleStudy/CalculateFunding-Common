﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateFunding.Common.ApiClient.DataSets.Models
{
    public class DatasetMetadataViewModel
    {
        public string DataDefinitionId { get; set; }
        public string DatasetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Filename { get; set; }
        public byte[] Stream { get; set; }
    }
}
