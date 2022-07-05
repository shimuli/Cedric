using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwShowSalesUnbatchedInvoice
    {
        public string SaleinvNumber { get; set; }
        public DateTime SaleinvDate { get; set; }
        public double? SaleinvNet { get; set; }
        public string CusCode { get; set; }
        public string CusRef { get; set; }
        public bool ItemselectionDone { get; set; }
        public double? TradeDiscount { get; set; }
        public string AnalysisCode { get; set; }
        public double ExchRate { get; set; }
        public string GlTradeaccount { get; set; }
        public double? Insure { get; set; }
        public double? MiscCharges { get; set; }
        public double? TranspCharge { get; set; }
        public double? TransportVat { get; set; }
        public string OrderNum { get; set; }
        public int SaleinvNum { get; set; }
        public int SaleinvDetNum { get; set; }
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
        public bool PreGrn { get; set; }
        public DateTime TransTime { get; set; }
        public double TaxAmt { get; set; }
        public string DeliveryNo { get; set; }
        public double? QtyOrdered { get; set; }
        public string Documentnumber { get; set; }
        public string CusDesc { get; set; }
        public string Currencycode { get; set; }
        public string TransSalesGl { get; set; }
        public string InventoryGl { get; set; }
        public string CostofsalesGl { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public string InvadjustmentGl { get; set; }
        public string DocSalesGl { get; set; }
        public double InvAvgcost { get; set; }
    }
}
