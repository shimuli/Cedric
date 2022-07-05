using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Barcode
    {
        public string InvCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Barcode1 { get; set; }
        public DateTime? BarcodeDate { get; set; }
        public string Description { get; set; }
        public string InvUnit { get; set; }
        public string InvStrength { get; set; }
        public string Username { get; set; }
        public string Updateuser { get; set; }
        public bool? Batched { get; set; }
        public DateTime? Entrydate { get; set; }
        public int Entrynum { get; set; }
    }
}
