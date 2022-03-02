namespace Methodical.Core.Entities
{
    public partial class University
    {
        public Guid UniversityGuid { get; set; }
        public string Locale { get; set; }
        public string Iso6391 { get; set; }
        public string Spelling { get; set; }
        public string SiteUrl { get; set; }
        public string AuthorityUrl { get; set; }
        public double? ThecitationsScore { get; set; }
        public double? TheindustryIncomeScore { get; set; }
        public double? TheinternationalOutlookScore { get; set; }
        public double? TheteachingScore { get; set; }
        public double? TheresearchScore { get; set; }
    }
}
