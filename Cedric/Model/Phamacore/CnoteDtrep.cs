using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CnoteDtrep
    {
        public int CnoteNum { get; set; }
        public int CnoteDetNum { get; set; }
        public string InvCode { get; set; }
        public double Quantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double Totalcost { get; set; }
        public short? DiscountCode { get; set; }
        public double? Bonusdiscount { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public double LineDisc { get; set; }
        public int SaleinvDetNum { get; set; }
        public double QtyLeft { get; set; }
        public string ModuleCode { get; set; }
        public bool? PreGrn { get; set; }
        public DateTime TransTime { get; set; }
        public double Bonus { get; set; }
        public double TaxAmt { get; set; }
        public int PrevDtno { get; set; }
        public string Documentnumber { get; set; }
        public int? Documenttype { get; set; }
        public double? Costofsale { get; set; }
        public int? StkNum { get; set; }
        public int? Mylineno { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int? Bcode { get; set; }
    }
}
