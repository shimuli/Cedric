using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Profitability
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public int? QtyIssued { get; set; }
        public double? Price { get; set; }
        public double? Cost { get; set; }
        public double? SalesValue { get; set; }
        public double? CostValue { get; set; }
        public double? Profit { get; set; }
        public double? PercentageProfit { get; set; }
        public double? Markup { get; set; }
        public string CusRef { get; set; }
        public string Sgcode { get; set; }
        public string Sgname { get; set; }
        public string Locname { get; set; }
        public double? Opbal { get; set; }
        public string LocCode { get; set; }
        public int? SalesTransactionNo { get; set; }
        public DateTime? TransDate { get; set; }
        public double? Opcost { get; set; }
        public double? Closebal { get; set; }
    }
}
