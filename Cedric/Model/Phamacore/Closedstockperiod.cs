using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Closedstockperiod
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public int? PackQty { get; set; }
        public double? Stkpos { get; set; }
        public string Stkpospw { get; set; }
        public int Bcode { get; set; }
        public double InvAvgcost { get; set; }
        public double InvLastunitcost { get; set; }
        public double InvTradeprice { get; set; }
        public double InvRetailprice { get; set; }
        public double? InvWsaleprice { get; set; }
        public string Processperiod { get; set; }
        public DateTime Processdate { get; set; }
        public string Subgroupcode { get; set; }
        public string Subgroupname { get; set; }
    }
}
