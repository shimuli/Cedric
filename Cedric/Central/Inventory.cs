using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Inventory
    {
        public string InvCode { get; set; }
        public string ActiveIngredient { get; set; }
        public string AltCode { get; set; }
        public string Barcode { get; set; }
        public int? Bcode { get; set; }
        public bool? Blocked { get; set; }
        public double? CashDiscount { get; set; }
        public double? CashinvoiceDiscount { get; set; }
        public bool? Choose { get; set; }
        public bool? Contsub { get; set; }
        public string Description { get; set; }
        public bool? Fastmoving { get; set; }
        public int? Formcode { get; set; }
        public bool? Forpackalter { get; set; }
        public bool? Forpackalterused { get; set; }
        public bool? Forrefill { get; set; }
        public bool? Highvalue { get; set; }
        public bool? Inclusive { get; set; }
        public bool? InvBrandgeneric { get; set; }
        public double? InvCostprice { get; set; }
        public double? InvInstockqty { get; set; }
        public double? InvMaxprice { get; set; }
        public int? InvMaxqty { get; set; }
        public double? InvMinprice { get; set; }
        public int? InvMinqty { get; set; }
        public string InvNotes { get; set; }
        public int? InvOpeningqty { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public int? InvReorderqty { get; set; }
        public double? InvRetailprice { get; set; }
        public double? InvSpecialprice { get; set; }
        public string InvStrength { get; set; }
        public string InvSubgroupcode { get; set; }
        public double? InvTradeprice { get; set; }
        public string InvUnit { get; set; }
        public double? InvWsaleprice { get; set; }
        public double? InvoiceDiscount { get; set; }
        public string LocCode { get; set; }
        public bool? Lockitemdiscount { get; set; }
        public bool? Lockprice { get; set; }
        public string ManufacturerCode { get; set; }
        public bool? Noexpiry { get; set; }
        public int? PackQty { get; set; }
        public string PackageCode { get; set; }
        public string PackinvCode { get; set; }
        public string PackinvName { get; set; }
        public int? Prodclass { get; set; }
        public double? Spack { get; set; }
        public string SuppCode { get; set; }
        public string SuppCode2 { get; set; }
        public double? Sweight { get; set; }
        public string TaxCode { get; set; }
        public int? UnitQty { get; set; }
        public bool? Yeszeroprice { get; set; }
    }
}
