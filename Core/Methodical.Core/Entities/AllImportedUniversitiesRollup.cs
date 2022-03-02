using System;
using System.Collections.Generic;

namespace Methodical.Core.Entities
{
    public partial class AllImportedUniversitiesRollup
    {
        public string Name { get; set; }
        public string DetailLink { get; set; }
        public double? TeachingScore { get; set; }
        public double? ResearchScore { get; set; }
        public double? CitationsScore { get; set; }
        public double? IndustryIncomeScore { get; set; }
        public double? InternationalOutlookScore { get; set; }
        public double? BlendedScore { get; set; }
        public string Iso3166Alpha2 { get; set; }
        public string Iso3166Alpha3 { get; set; }
        public short? Iso3166Numeric { get; set; }
    }
}
