using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stktakeinvsubgroup
    {
        public int Stkref { get; set; }
        public int Bcode { get; set; }
        public string InvSubgroupcode { get; set; }
        public string Description { get; set; }
        public int? Doctype { get; set; }
    }
}
