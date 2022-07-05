using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Impinv2020
    {
        public string InvSubgroupcode { get; set; }
        public string InvSubgroupname { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public int? PackQty { get; set; }
        public string ManufacturerCode { get; set; }
        public string TaxCode { get; set; }
        public double InvRetailprice { get; set; }
        public double InvTradeprice { get; set; }
        public double InvAvgcost { get; set; }
        public double InvLastunitcost { get; set; }
        public string Username { get; set; }
        public int Userid { get; set; }
    }
}
