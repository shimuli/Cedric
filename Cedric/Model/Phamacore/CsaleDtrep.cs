using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CsaleDtrep
    {
        public int CsaleNum { get; set; }
        public int CsaleDetNum { get; set; }
        public string InvCode { get; set; }
        public double? Quantity { get; set; }
        public string TaxCode { get; set; }
        public double? Price { get; set; }
        public string Unit { get; set; }
        public double? Totalcost { get; set; }
        public short? DiscountCode { get; set; }
        public double? Bonusdiscount { get; set; }
        public string Description { get; set; }
        public string Strength { get; set; }
        public double? LineDisc { get; set; }
        public string InvStrength { get; set; }
        public int? Bonus { get; set; }
        public string AdultChild { get; set; }
        public double QtyLeft { get; set; }
        public int ModuleCode { get; set; }
        public bool? PreGrn { get; set; }
        public DateTime TransTime { get; set; }
        public int? SoDetNum { get; set; }
        public double? QtyOrdered { get; set; }
        public double? Costofsale { get; set; }
        public int? StkNum { get; set; }
        public double? Cnoteqty { get; set; }
        public int? Mylineno { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int? Bcode { get; set; }

        public virtual CsaleHdrep CsaleNumNavigation { get; set; }
    }
}
