using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesPlan
    {
        public string InvCode { get; set; }
        public short SalesYear { get; set; }
        public double YearPlan { get; set; }
        public string Description { get; set; }
        public double? YearPlanSales { get; set; }
    }
}
