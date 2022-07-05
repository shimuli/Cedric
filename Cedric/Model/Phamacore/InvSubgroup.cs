using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvSubgroup
    {
        public string InvGroupcode { get; set; }
        public string InvSubgroupcode { get; set; }
        public string Description { get; set; }
        public string InvSubgroupbarcode { get; set; }
        public bool? Gl { get; set; }
        public int? M1from { get; set; }
        public int? M1to { get; set; }
        public int? M2from { get; set; }
        public int? M2to { get; set; }
        public int? M3from { get; set; }
        public int? M3to { get; set; }
        public int? M4from { get; set; }
        public bool? Isacct { get; set; }
    }
}
