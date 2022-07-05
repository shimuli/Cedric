using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCashSaleCreditNote
    {
        public string CsaleNumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public double Cnoteqty { get; set; }
        public double? Quantity { get; set; }
        public double? Balance { get; set; }
        public int CsaleDetNum { get; set; }
        public string Partwhole { get; set; }
        public int? Bcode { get; set; }
    }
}
