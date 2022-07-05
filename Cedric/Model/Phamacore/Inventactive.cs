using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Inventactive
    {
        public string InvSubgroupcode { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string TaxCode { get; set; }
        public double? InvTradeprice { get; set; }
        public double? PackQty { get; set; }
        public string Active { get; set; }
        public string F8 { get; set; }
        public string F9 { get; set; }
    }
}
