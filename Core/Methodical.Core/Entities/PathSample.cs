using System;
using System.Collections.Generic;

namespace Methodical.Core.Entities
{
    public partial class PathSample
    {
        public Guid? TenantGuid { get; set; }
        public Guid? FromNode { get; set; }
        public Guid? ToNode { get; set; }
        public Guid SampleGuid { get; set; }
        public string PathFingerprint { get; set; }
        public float? PathStrength { get; set; }
        public decimal? CostAllocation { get; set; }
    }
}
