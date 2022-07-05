using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Invcentral
    {
        public string InvCode { get; set; }
        public int Bcode { get; set; }
        public double? InvAvgcost { get; set; }
        public double? InvLastunitcost { get; set; }
        public double? InvCostprice { get; set; }
        public double? InvMinprice { get; set; }
        public double? InvRetailprice { get; set; }
        public double? InvTradeprice { get; set; }
        public double? InvSpecialprice { get; set; }
        public double? InvAvgsellcost { get; set; }
    }
}
