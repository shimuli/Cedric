using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CnoteDt
    {
        public int CnoteNum { get; set; }
        public int Bcode { get; set; }
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
        public string Clcoredoc { get; set; }
        public int? Clvisit { get; set; }
        public int? ProcCode { get; set; }
        public string EmpNum { get; set; }
        public double? Excise { get; set; }
        public double? Itemavgcost { get; set; }
        public int? Inclusive { get; set; }
        public double? Priceincl { get; set; }
        public int? DeptCode { get; set; }
        public int CnoteDetNum { get; set; }
        public bool? Credpenalty { get; set; }
        public bool? Copay { get; set; }
        public int? CopaycnoteNum { get; set; }
        public int? CopaycnoteDetNum { get; set; }
        public int? CopaycnoteBcode { get; set; }
        public string Copaycuscode { get; set; }
        public string Copayreason { get; set; }
        public int? Loynum { get; set; }
        public int? Loydetnum { get; set; }
        public int? Loybcode { get; set; }
        public double? Loypoints { get; set; }
        public int? Loydettype { get; set; }
    }
}
