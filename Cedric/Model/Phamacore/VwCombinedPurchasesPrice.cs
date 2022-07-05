using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCombinedPurchasesPrice
    {
        public string InvCode { get; set; }
        public double Price { get; set; }
        public double? Quantity { get; set; }
        public double? Totalcost { get; set; }
    }
}
