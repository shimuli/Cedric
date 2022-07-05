using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCashSaleCreditNotePart
    {
        public string CsaleNumber { get; set; }
        public string Description { get; set; }
        public double Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public double Cnoteqty { get; set; }
        public double? Quantity { get; set; }
        public double? Balance { get; set; }
        public int CsaleDetNum { get; set; }
        public string Partwhole { get; set; }
        public string PartCnoteqty { get; set; }
        public string Partquantity { get; set; }
        public string Partbalance { get; set; }
        public int? Bcode { get; set; }
    }
}
