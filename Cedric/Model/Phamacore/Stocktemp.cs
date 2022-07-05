using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stocktemp
    {
        public string InvCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string LocCode { get; set; }
        public string BatchNum { get; set; }
        public DateTime? StockDate { get; set; }
        public string Description { get; set; }
        public int? StockQty { get; set; }
        public int? CompQty { get; set; }
        public string InvUnit { get; set; }
        public string InvStrength { get; set; }
        public string Username { get; set; }
        public string Updateuser { get; set; }
    }
}
