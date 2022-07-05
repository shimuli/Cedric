using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printjournal
    {
        public int ScJDetnum { get; set; }
        public DateTime? ScJDate { get; set; }
        public string CusCode { get; set; }
        public string SuppCode { get; set; }
        public string GCode { get; set; }
        public string ScJRef { get; set; }
        public string ScJDesc { get; set; }
        public double ScJAmount { get; set; }
        public string ScJTax { get; set; }
        public double ScJInclusive { get; set; }
        public string ScJDc { get; set; }
        public string ScJName { get; set; }
        public string ScJSc { get; set; }
        public bool Batched { get; set; }
        public string ScJContra { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public double Usin { get; set; }
        public double Balance { get; set; }
        public double Paid { get; set; }
        public string Sflag { get; set; }
        public string Username { get; set; }
        public bool BankCleared { get; set; }
        public DateTime? ClearingDate { get; set; }
        public DateTime? PayDue { get; set; }
        public DateTime? AwbDate { get; set; }
        public short? Fromhistory { get; set; }
        public string Mydocref { get; set; }
        public short? Jvtype { get; set; }
        public double? Newamt { get; set; }
        public DateTime? DatePosted { get; set; }
        public bool? Dontshow { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public int? Batchnum { get; set; }
        public string Printuser { get; set; }
    }
}
