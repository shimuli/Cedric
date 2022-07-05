using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Cusstockprice
    {
        public string CusCode { get; set; }
        public string InvCode { get; set; }
        public double? Stkprice { get; set; }
        public int? Stkpricenum { get; set; }
    }
}
