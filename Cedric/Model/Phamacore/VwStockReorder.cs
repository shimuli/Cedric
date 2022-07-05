using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwStockReorder
    {
        public string Companyname { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public string InvUnit { get; set; }
        public double InvInstockqty { get; set; }
        public double? InvMinqty { get; set; }
        public double? InvReorderqty { get; set; }
        public string Suppliername { get; set; }
        public string Spcode { get; set; }
        public double Lastprice { get; set; }
        public double? Reoqty { get; set; }
        public double? H { get; set; }
        public double? Avgsales { get; set; }
        public string Manufname { get; set; }
        public double InvAvgcost { get; set; }
        public double InvLastunitcost { get; set; }
    }
}
