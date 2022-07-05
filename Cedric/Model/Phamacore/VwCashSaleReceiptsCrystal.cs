using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCashSaleReceiptsCrystal
    {
        public int CsaleNum { get; set; }
        public DateTime CsaleDate { get; set; }
        public double? CsaleNet { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Unit { get; set; }
        public string Strength { get; set; }
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        public short? DiscountCode { get; set; }
        public double? Bonusdiscount { get; set; }
        public double? Totalcost { get; set; }
        public double? Taxamount { get; set; }
        public double? Bonusamt { get; set; }
        public double? Discount { get; set; }
        public double? TotalDiscount { get; set; }
        public string CsaleNumber { get; set; }
        public double? LineDisc { get; set; }
        public string InvStrength { get; set; }
        public string Comments { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Paymode { get; set; }
        public string BankAcct { get; set; }
        public string BankName { get; set; }
        public string Reference { get; set; }
        public double? CsaleVat { get; set; }
        public string CashCollector { get; set; }
        public string CustomerName { get; set; }
        public double? CsaleTotal { get; set; }
        public double? Disc { get; set; }
        public double? Excl { get; set; }
        public double? Excl2 { get; set; }
        public double? TradeDiscount { get; set; }
        public string Currencyname { get; set; }
        public string Symbol { get; set; }
        public double Cashpaid { get; set; }
        public double Cashbalance { get; set; }
        public double? QtyOrdered { get; set; }
        public int CsaleDetNum { get; set; }
        public int? NumRecs { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CusCode { get; set; }
        public string UserName { get; set; }
    }
}
