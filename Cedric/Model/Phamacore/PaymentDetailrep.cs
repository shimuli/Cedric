using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class PaymentDetailrep
    {
        public int? PayDetnum { get; set; }
        public double? Amount { get; set; }
        public string SinvNumber { get; set; }
        public string Reference { get; set; }
        public double? Paycounter { get; set; }
        public int? PayNum { get; set; }
        public int Entrynum { get; set; }
        public int? Bcode { get; set; }
    }
}
