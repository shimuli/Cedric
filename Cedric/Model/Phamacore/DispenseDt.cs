using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class DispenseDt
    {
        public int DispenseNum { get; set; }
        public int DispenseDetNum { get; set; }
        public string InvCode { get; set; }
        public double Quantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double Totalcost { get; set; }
        public short? DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public DateTime? Expiry { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public double LineDisc { get; set; }
        public double Newtotalcost { get; set; }
        public double Newprice { get; set; }
        public double? OrdQuantity { get; set; }
        public double? Bonus { get; set; }
        public string ManufC { get; set; }
        public int? SoDetNum { get; set; }
        public double? Returned { get; set; }
        public double? Taken { get; set; }
        public string AdultChild { get; set; }
        public double QtyLeft { get; set; }
        public int ModuleCode { get; set; }
        public bool? PreGrn { get; set; }
        public DateTime TransTime { get; set; }
        public double TaxAmt { get; set; }
        public string DeliveryNo { get; set; }
        public double? QtyOrdered { get; set; }
        public int? SaleinvNum { get; set; }
        public double? Costofsale { get; set; }
        public int? StkNum { get; set; }
        public int? Mylineno { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int? Bcode { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public int? W1 { get; set; }
        public int? W2 { get; set; }
        public int? Authorisecode { get; set; }
        public double? Excise { get; set; }
        public string Clcoredoc { get; set; }
        public int? Clvisit { get; set; }
        public int? ProcCode { get; set; }
        public string EmpNum { get; set; }
        public bool? Bill { get; set; }
        public int? Labt { get; set; }
        public int? Theatret { get; set; }
        public int? Xrayt { get; set; }
        public int? Drugtentryno { get; set; }
        public double? Xpaid { get; set; }
        public int? Cashallow { get; set; }
    }
}
