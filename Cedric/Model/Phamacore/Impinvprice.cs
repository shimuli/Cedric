using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Impinvprice
    {
        public string InvSubgroupcode { get; set; }
        public string Sbgname { get; set; }
        public bool? Sbggl { get; set; }
        public bool? Sbgisacct { get; set; }
        public string Gpcode { get; set; }
        public string Gpname { get; set; }
        public string SalesGl { get; set; }
        public string CostofsalesGl { get; set; }
        public string InvadjustmentGl { get; set; }
        public string InventoryGl { get; set; }
        public bool? Gpisacct { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public int PackQty { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public double? InvTradeprice { get; set; }
        public double? InvRetailprice { get; set; }
        public double? InvWsaleprice { get; set; }
        public double? InvSpecialprice { get; set; }
        public double? InvMinprice { get; set; }
        public double? InvMaxprice { get; set; }
        public double? InvAvgsellcost { get; set; }
        public double? InvAvgcost { get; set; }
        public double? InvLastunitcost { get; set; }
        public double? InvCostprice { get; set; }
        public string TaxCode { get; set; }
        public bool Inclusive { get; set; }
        public double? InvoiceDiscount { get; set; }
        public double? CashDiscount { get; set; }
        public bool? Selme { get; set; }
        public string Invuser { get; set; }
        public bool? Yeszeroprice { get; set; }
        public bool? Lockprice { get; set; }
        public string ManufacturerCode { get; set; }
        public string Mnfname { get; set; }
        public string Mnfcountry { get; set; }
        public string Mnfintial { get; set; }
        public bool? Show1 { get; set; }
        public bool? Show2 { get; set; }
        public bool? Show3 { get; set; }
        public bool? Show4 { get; set; }
        public bool? Show5 { get; set; }
        public bool? Show6 { get; set; }
        public bool? Show7 { get; set; }
        public bool? Show8 { get; set; }
        public bool? Show9 { get; set; }
        public bool? Blocked { get; set; }
        public bool? Kisimax { get; set; }
        public string Barcode { get; set; }
    }
}
