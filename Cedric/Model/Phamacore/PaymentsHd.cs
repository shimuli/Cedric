using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class PaymentsHd
    {
        public string BankAcct { get; set; }
        public DateTime? PayDate { get; set; }
        public string SuppCode { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public bool Batched { get; set; }
        public int PayDetnum { get; set; }
        public int Bcode { get; set; }
        public double Amountpaid { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public bool Done { get; set; }
        public double Using { get; set; }
        public string Paymode { get; set; }
        public string Amountinwords { get; set; }
        public bool Matched { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Gcs { get; set; }
        public string Gcode { get; set; }
        public string CusCode { get; set; }
        public double ExchRate { get; set; }
        public string SinvNumber { get; set; }
        public string Currencycode { get; set; }
        public double Clearingamount { get; set; }
        public string Theircurrencycode { get; set; }
        public double Homeamountpaid { get; set; }
        public string Payfor { get; set; }
        public string Comments { get; set; }
        public bool Cleared { get; set; }
        public double Paid { get; set; }
        public string UserName { get; set; }
        public bool BankCleared { get; set; }
        public DateTime? ClearingDate { get; set; }
        public string Period { get; set; }
        public int PayNum { get; set; }
        public int Paycounter { get; set; }
        public short? Fromhistory { get; set; }
        public DateTime? RptClearingDate { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public string TaxCode { get; set; }
        public double? TaxAmt { get; set; }
        public double? ExclAmt { get; set; }
        public bool? Bposted { get; set; }
        public DateTime? Entrydate { get; set; }
        public bool? Cashsale { get; set; }
        public bool? Cashier { get; set; }
        public string Memberno { get; set; }
        public int? Tillno { get; set; }
        public int? Tillsessno { get; set; }
        public int? Contrabcode { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
        public bool? Selrec { get; set; }
        public bool? Revdoc { get; set; }
        public bool? Docbanked { get; set; }
        public string Referenceother { get; set; }
        public int? DeptCode { get; set; }
        public int? Whvat { get; set; }
        public string Whvatcode { get; set; }
        public double? Whvatperc { get; set; }
        public double? Whvatamt { get; set; }
        public string Txtype { get; set; }
        public double? Txperc { get; set; }
        public int? Cnotenum { get; set; }
        public int? Cnotebcode { get; set; }
        public int? Mpickno { get; set; }
        public int? Mpickbcode { get; set; }
        public int? Mpesaentryno { get; set; }
        public string Mpesatransid { get; set; }
        public bool? Frompd { get; set; }
        public bool? Suppcleared { get; set; }
        public DateTime? Suppclearingdate { get; set; }
    }
}
