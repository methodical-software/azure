using System;
using System.Collections.Generic;

namespace Methodical.Core.Entities
{
    public partial class AllImportedUniversitiesPipeline2
    {
        public string Name { get; set; }
        public string DetailLink { get; set; }
        public string Country { get; set; }
        public double? TeachingScore { get; set; }
        public double? ResearchScore { get; set; }
        public double? CitationsScore { get; set; }
        public double? IndustryIncomeScore { get; set; }
        public double? InternationalOutlookScore { get; set; }
    }
}
