using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Journalimport
    {
        public string CusCode { get; set; }
        public string ScJName { get; set; }
        public DateTime? ScJDate { get; set; }
        public string ScJRef { get; set; }
        public string ScJDesc { get; set; }
        public double? ScJAmount { get; set; }
        public string ScJTax { get; set; }
        public double? ScJInclusive { get; set; }
        public string ScJDc { get; set; }
        public string ScJSc { get; set; }
        public string ScJContra { get; set; }
        public double? Batched { get; set; }
        public double? ExchRate { get; set; }
        public double? Currencycode { get; set; }
        public double? Usin { get; set; }
        public double? Balance { get; set; }
        public double? Paid { get; set; }
        public string Username { get; set; }
        public double? BankCleared { get; set; }
        public double? Fromhistory { get; set; }
        public DateTime? DatePosted { get; set; }
        public double? Dontshow { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
    }
}
