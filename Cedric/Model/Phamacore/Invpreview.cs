using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Invpreview
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double InvAvgcost { get; set; }
        public double InvLastunitcost { get; set; }
        public string TaxCode { get; set; }
        public double InvMinprice { get; set; }
        public double InvMaxprice { get; set; }
        public double InvRetailprice { get; set; }
        public double InvCostprice { get; set; }
        public double InvTradeprice { get; set; }
        public double InvSpecialprice { get; set; }
        public bool? InvBrandgeneric { get; set; }
        public double? InvAvgsellcost { get; set; }
        public double? Iavgcost { get; set; }
        public double? Ilucost { get; set; }
        public double? Iavgsell { get; set; }
    }
}
