﻿using System.Collections.Generic;
using System.Linq;

namespace CalculateFunding.Common.ApiClient.Profiling.Models
{
    public class ProviderProfilingRequestModel
    {
        public ProviderProfilingRequestModel()
        {
        }
        public string FundingStreamId { get; set; }

        public string FundingPeriodId { get; set; }

        public string FundingLineCode { get; set; }

        public decimal? FundingValue { get; set; }
    }
}
