using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Newinventory
    {
        public string InvSubgroupcode { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string InvItemcontents { get; set; }
        public string InvStrength { get; set; }
        public string PackageCode { get; set; }
        public string ManufacturerCode { get; set; }
        public string InvCountryorigin { get; set; }
        public string InvUnit { get; set; }
        public int UnitQty { get; set; }
        public double InvInstockqty { get; set; }
        public int InvOpeningqty { get; set; }
        public int InvMinqty { get; set; }
        public int InvMaxqty { get; set; }
        public int InvReorderqty { get; set; }
        public double InvAvgcost { get; set; }
        public double InvLastunitcost { get; set; }
        public bool? Blocked { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public string TaxCode { get; set; }
        public double InvMinprice { get; set; }
        public double InvMaxprice { get; set; }
        public double InvRetailprice { get; set; }
        public double InvCostprice { get; set; }
        public double InvTradeprice { get; set; }
        public double InvSpecialprice { get; set; }
        public bool? InvBrandgeneric { get; set; }
        public bool? DiscountAvailable { get; set; }
        public string InvNotes { get; set; }
        public bool? TransferItem { get; set; }
        public double? InvAvgsellcost { get; set; }
        public bool? Noexpiry { get; set; }
        public string ProvisionCode { get; set; }
        public bool? Deleted { get; set; }
        public int Counter { get; set; }
        public string AltCode { get; set; }
        public int? PackQty { get; set; }
        public bool? RetailItem { get; set; }
        public string Manufacturer { get; set; }
        public string LogicalGroup { get; set; }
        public string LocCode { get; set; }
        public double Salesprofit { get; set; }
        public int? OpeningQty { get; set; }
        public int? Isqty { get; set; }
        public double? Iavgcost { get; set; }
        public double? Ilucost { get; set; }
        public double? Iavgsell { get; set; }
        public string Newcode { get; set; }
        public double? InvOldCostprice { get; set; }
        public double? Newavgcost { get; set; }
        public double? InvoiceDiscount { get; set; }
        public double? CashDiscount { get; set; }
        public string ActiveIngredient { get; set; }
        public string Barcode { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public int? W1 { get; set; }
        public int? W2 { get; set; }
        public int? CalcQty { get; set; }
        public int? Valqty { get; set; }
        public int? ReQty { get; set; }
        public string Username { get; set; }
        public string Wholecount { get; set; }
    }
}
