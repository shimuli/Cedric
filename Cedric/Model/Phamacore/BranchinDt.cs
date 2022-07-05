using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BranchinDt
    {
        public int BrinNum { get; set; }
        public string InvCode { get; set; }
        public int Quantity { get; set; }
        public int Metquantity { get; set; }
        public int Remquantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public double Totalcost { get; set; }
        public short DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvStrength { get; set; }
        public double LineDisc { get; set; }
        public bool Detpending { get; set; }
        public double? Bonus { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int? Mylineno { get; set; }
        public int? BorderDetNum { get; set; }
        public int? Bcodefrom { get; set; }
        public int BrinDetNum { get; set; }
        public int Bcode { get; set; }
    }
}
