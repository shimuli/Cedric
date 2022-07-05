using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class GretDt
    {
        public int GretNum { get; set; }
        public int GretDetNum { get; set; }
        public int Bcode { get; set; }
        public string InvCode { get; set; }
        public double? Quantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double Totalcost { get; set; }
        public short DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public DateTime? Expiry { get; set; }
        public double LineDisc { get; set; }
        public int TransNumber { get; set; }
        public int SinvDetNum { get; set; }
        public int Bonus { get; set; }
        public int? StkNum { get; set; }
        public int? InstkNum { get; set; }
        public int? Mylineno { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public DateTime? Entrydate { get; set; }
        public double? Excise { get; set; }
        public int? DeptCode { get; set; }
        public string Txtype { get; set; }
        public double? Txperc { get; set; }
        public double? Costfactor { get; set; }
    }
}
