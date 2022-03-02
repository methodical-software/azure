using System;
using System.Collections.Generic;

namespace Methodical.Core.Entities
{
    public partial class Portfolio
    {
        public Guid TenantGuid { get; set; }
        public Guid PortfolioGuid { get; set; }
        public string UserLabel { get; set; }
        public decimal? PortfolioCost { get; set; }
    }
}
