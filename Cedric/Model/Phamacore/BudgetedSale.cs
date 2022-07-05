using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BudgetedSale
    {
        public string InvCode { get; set; }
        public string SalesMonth { get; set; }
        public int? Qty { get; set; }
        public double? Salesval { get; set; }
    }
}
