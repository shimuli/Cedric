using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stockskeydip
    {
        public DateTime? TransDate { get; set; }
        public string InvCode { get; set; }
        public string InvName { get; set; }
        public string InvPhysical { get; set; }
        public string InvManuf { get; set; }
        public string InvGroup { get; set; }
        public string InvSubgroup { get; set; }
        public string InvStockclassif { get; set; }
        public string InvStockmainclass { get; set; }
        public string InvStockform { get; set; }
        public double? StockQty { get; set; }
        public double? StockValue { get; set; }
        public double? CostAvgcostvalue { get; set; }
        public double? CostLastcostvalue { get; set; }
        public string Printuser { get; set; }
        public double? InvPackqty { get; set; }
        public double? StockPwqty { get; set; }
        public string StockPw { get; set; }
        public string Datecrit { get; set; }
        public string Othercrit { get; set; }
        public string Branchname { get; set; }
        public int? Branchid { get; set; }
    }
}
