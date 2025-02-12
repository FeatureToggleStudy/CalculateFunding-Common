﻿using System.Collections.Generic;

namespace CalculateFunding.Common.ApiClient.Calcs.Models.Code
{
    public class MethodInformation
    {
        public string Name { get; set; }

        public string FriendlyName { get; set; }

        public string Description { get; set; }

        public IEnumerable<ParameterInformation> Parameters { get; set; }

        public string ReturnType { get; set; }

        public string EntityId { get; set; }

        public bool IsCustom { get; set; }
    }
}
