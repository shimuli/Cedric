using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class GrnDt
    {
        public int GrnNum { get; set; }
        public int GrnDetNum { get; set; }
        public int Bcode { get; set; }
        public string InvCode { get; set; }
        public int Quantity { get; set; }
        public int DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public string InvStrength { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public DateTime? Expiry { get; set; }
        public int OrdQuantity { get; set; }
        public int TransNumber { get; set; }
        public double ItemCost { get; set; }
        public double Prov { get; set; }
        public double Tcost { get; set; }
        public int SinvDetNum { get; set; }
        public int PorderDetNum { get; set; }
        public int Metquantity { get; set; }
        public int Remquantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public double Totalcost { get; set; }
        public double LineDisc { get; set; }
        public int Taken { get; set; }
        public int Returned { get; set; }
        public int Bonus { get; set; }
        public int QtyLeft { get; set; }
        public int ModuleCode { get; set; }
        public bool? PreGrn { get; set; }
        public DateTime TransTime { get; set; }
        public string ProvisionCode { get; set; }
        public string ProvisionDesc { get; set; }
        public int? StkNum { get; set; }
        public int? Mylineno { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
