using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BrnDt
    {
        public int BrnNum { get; set; }
        public int Bcode { get; set; }
        public string InvCode { get; set; }
        public double Quantity { get; set; }
        public double Metquantity { get; set; }
        public double Remquantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double Totalcost { get; set; }
        public short DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public string InvStrength { get; set; }
        public string Description { get; set; }
        public double LineDisc { get; set; }
        public double OrdQuantity { get; set; }
        public double Bonus { get; set; }
        public double Ordered { get; set; }
        public int TransNumber { get; set; }
        public bool Detpending { get; set; }
        public int BorderDetNum { get; set; }
        public double Taken { get; set; }
        public double Returned { get; set; }
        public double QtyLeft { get; set; }
        public int ModuleCode { get; set; }
        public bool? PreGrn { get; set; }
        public DateTime TransTime { get; set; }
        public double PreferredPrice { get; set; }
        public double? Costfactor { get; set; }
        public int? StkNum { get; set; }
        public int Mylineno { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int? Importbrn { get; set; }
        public int BrnDetNum { get; set; }
        public int? BtransDetNum { get; set; }
    }
}
