using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCombinedSale
    {
        public string InvCode { get; set; }
        public double? Unitsales { get; set; }
        public string LocCode { get; set; }
        public int Closingsales { get; set; }
    }
}
