using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BankingHd
    {
        public string BankAcct { get; set; }
        public DateTime? BnkDate { get; set; }
        public int BnkDetnum { get; set; }
        public int RptDetnum { get; set; }
        public string CusCode { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public bool Batched { get; set; }
        public double Amountpaid { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public bool Done { get; set; }
        public double Usin { get; set; }
        public string Paymode { get; set; }
        public string Amountinwords { get; set; }
        public bool Matched { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Gcs { get; set; }
        public string Gcode { get; set; }
        public string SuppCode { get; set; }
        public double ExchRate { get; set; }
        public string SaleinvNumber { get; set; }
        public string Currencycode { get; set; }
        public double Clearingamount { get; set; }
        public string Theircurrencycode { get; set; }
        public double Homeamountpaid { get; set; }
        public string Payfor { get; set; }
        public string Comments { get; set; }
        public bool Cleared { get; set; }
        public bool Bounced { get; set; }
        public bool Holding { get; set; }
        public bool Rcptfromcsale { get; set; }
        public string UserName { get; set; }
        public bool BankCleared { get; set; }
        public DateTime? ClearingDate { get; set; }
        public string Period { get; set; }
        public string BnkNumber { get; set; }
        public int Rptcounter { get; set; }
        public string BnkTax { get; set; }
        public int BnkNum { get; set; }
        public short? Fromhistory { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public string TaxCode { get; set; }
        public double? TaxAmt { get; set; }
        public double? ExclAmt { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
        public DateTime? Entrydate { get; set; }
        public bool? Cashier { get; set; }
        public string Memberno { get; set; }
        public int? Tillno { get; set; }
        public int? Tillsessno { get; set; }
        public int? Clallocnum { get; set; }
        public int? Visitentrynum { get; set; }
        public int? Visitid { get; set; }
        public int? DependNo { get; set; }
        public bool? Clinic { get; set; }
        public bool? Inpatient { get; set; }
        public int? Admid { get; set; }
        public int? Admentrynum { get; set; }
        public string Referenceother { get; set; }
        public string DoctNum { get; set; }
        public bool? Cashsale { get; set; }
        public bool? Deposit { get; set; }
        public bool? Revdoc { get; set; }
        public int? Contrabcode { get; set; }
        public int? Appstat { get; set; }
        public string Appcomments { get; set; }
        public string Appuser { get; set; }
        public int? Glrefcode { get; set; }
        public int? ScJDetnum { get; set; }
        public bool? Docbanked { get; set; }
        public int? BankBnkDetnum { get; set; }
        public int? Banktillsessno { get; set; }
        public int? Banktillno { get; set; }
        public bool? Docselect { get; set; }
        public string BankbankAcct { get; set; }
        public string BankbankName { get; set; }
    }
}
