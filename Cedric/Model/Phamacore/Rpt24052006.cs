using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Rpt24052006
    {
        public string BankAcct { get; set; }
        public DateTime? RptDate { get; set; }
        public string CusCode { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public bool Batched { get; set; }
        public int RptDetnum { get; set; }
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
        public string RptNumber { get; set; }
        public int Rptcounter { get; set; }
        public string RptTax { get; set; }
        public int RptNum { get; set; }
        public short? Fromhistory { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
    }
}
