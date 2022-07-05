using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwInventoryStatementRunningBal
    {
        public string InvCode { get; set; }
        public double? SumOfQtyIn { get; set; }
        public double? SumOfQtyOut { get; set; }
        public double? Bal { get; set; }
    }
}
