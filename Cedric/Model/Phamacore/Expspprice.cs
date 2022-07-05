using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Expspprice
    {
        public string SuppCode { get; set; }
        public string InvCode { get; set; }
        public int Disctype { get; set; }
        public double? Tradeprice { get; set; }
        public double? Sppriceamt { get; set; }
        public double? Spdiscount { get; set; }
        public int? Bonus { get; set; }
        public string Bonuspw { get; set; }
        public int? Spbonus { get; set; }
        public string Spbonuspw { get; set; }
        public int? Discmode { get; set; }
        public int? Sppriceentrynum { get; set; }
        public DateTime? Discexpirydate { get; set; }
        public bool? Sppriceapply { get; set; }
        public double? Pwqty { get; set; }
        public double? Sppwqty { get; set; }
        public bool? Selme { get; set; }
        public string Invuser { get; set; }
    }
}
