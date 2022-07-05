using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Cusstockprice
    {
        public string CusCode { get; set; }
        public string InvCode { get; set; }
        public double? Stkprice { get; set; }
        public double? Stkpricediscount { get; set; }
        public int? Pricecompare { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public bool Expired { get; set; }
        public bool Disable { get; set; }
        public int Stkpricenum { get; set; }
    }
}
