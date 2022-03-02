using System;
using System.Collections.Generic;

namespace Methodical.Core.Entities
{
    public partial class Country
    {
        public Guid CountryGuid { get; set; }
        public string Semantic { get; set; }
        public string Characters { get; set; }
        public string Iso6391 { get; set; }
        public string Spelling { get; set; }
        public string Iso3166Alpha2 { get; set; }
        public string Iso3166Alpha3 { get; set; }
        public short Iso3166Numeric { get; set; }
    }
}
