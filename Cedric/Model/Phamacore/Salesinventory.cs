using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Salesinventory
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string LocCode { get; set; }
        public double? QtyIssued { get; set; }
        public double? QtyReturned { get; set; }
        public double? Price { get; set; }
        public double? Cost { get; set; }
        public double? SalesValue { get; set; }
        public double? CostValue { get; set; }
        public double? Profit { get; set; }
        public double? PercentageProfit { get; set; }
        public double? Markup { get; set; }
        public string Sgcode { get; set; }
        public string Sgname { get; set; }
        public double? PercUnits { get; set; }
        public double? PercSales { get; set; }
        public double? PercProfit { get; set; }
    }
}
