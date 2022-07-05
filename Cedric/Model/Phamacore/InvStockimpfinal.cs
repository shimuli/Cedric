using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvStockimpfinal
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double? StockQty { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string LocCode { get; set; }
        public string BatchNum { get; set; }
        public double? CompQty { get; set; }
        public string InvUnit { get; set; }
        public string InvStrength { get; set; }
        public string Username { get; set; }
        public double? Batched { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
    }
}
