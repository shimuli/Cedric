using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCombinedPurchase
    {
        public string InvCode { get; set; }
        public double? Unitpurchases { get; set; }
        public string LocCode { get; set; }
        public int Closingsales { get; set; }
    }
}
