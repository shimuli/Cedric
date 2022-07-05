using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Invento
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
        public double? UnitQty { get; set; }
        public double? InvInstockqty { get; set; }
        public double? InvOpeningqty { get; set; }
        public double? InvMinqty { get; set; }
        public double? InvMaxqty { get; set; }
        public double? InvReorderqty { get; set; }
        public double? InvAvgcost { get; set; }
        public double? InvLastunitcost { get; set; }
        public double? Blocked { get; set; }
        public double? InvPhysicalitem { get; set; }
        public string TaxCode { get; set; }
        public double? InvMinprice { get; set; }
        public double? InvMaxprice { get; set; }
        public double? InvRetailprice { get; set; }
        public double? InvCostprice { get; set; }
        public double? InvTradeprice { get; set; }
        public double? InvSpecialprice { get; set; }
        public double? InvBrandgeneric { get; set; }
        public double? DiscountAvailable { get; set; }
        public string InvNotes { get; set; }
        public double? TransferItem { get; set; }
        public double? InvAvgsellcost { get; set; }
        public double? Noexpiry { get; set; }
        public string ProvisionCode { get; set; }
        public double? Deleted { get; set; }
        public double? Counter { get; set; }
        public string AltCode { get; set; }
        public double? PackQty { get; set; }
        public double? RetailItem { get; set; }
        public string Manufacturer { get; set; }
        public string LogicalGroup { get; set; }
        public string LocCode { get; set; }
        public double? Salesprofit { get; set; }
        public string ActiveIngredient { get; set; }
    }
}
