﻿using CalculateFunding.Common.Models;

namespace CalculateFunding.Common.ApiClient.Policies.Models
{
    public class AllocationLine : Reference
    {
        public AllocationLine()
        {
        }

        public AllocationLine(string id, string name)
            : base(id, name)
        {

        }
    }
}