using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class InvSubgroup
    {
        public string InvSubgroupcode { get; set; }
        public string InvGroupcode { get; set; }
        public string Description { get; set; }
        public int? M1from { get; set; }
        public int? M1to { get; set; }
        public int? M2from { get; set; }
        public int? M2to { get; set; }
        public int? M3from { get; set; }
        public int? M3to { get; set; }
    }
}
