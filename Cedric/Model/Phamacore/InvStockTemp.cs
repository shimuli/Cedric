using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvStockTemp
    {
        public string InvCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string LocCode { get; set; }
        public string BatchNum { get; set; }
        public DateTime? StockDate { get; set; }
        public string Description { get; set; }
        public double StockQty { get; set; }
        public double CompQty { get; set; }
        public string InvUnit { get; set; }
        public string InvStrength { get; set; }
        public string Username { get; set; }
        public string Updateuser { get; set; }
        public int? Entrynum { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public string Barcode { get; set; }
        public int? Bcode { get; set; }
    }
}
