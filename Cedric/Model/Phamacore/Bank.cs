using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Bank
    {
        public string BankAcct { get; set; }
        public string BankName { get; set; }
        public string GlBankcode { get; set; }
        public string BankGl { get; set; }
        public string Currencycode { get; set; }
        public bool Postdated { get; set; }
        public bool? Isbank { get; set; }
        public bool? Blocked { get; set; }
        public bool? Pettycash { get; set; }
        public int? Cbstyle { get; set; }
        public int? Banksystem { get; set; }
        public double? Cashlimit { get; set; }
        public int? Bcode { get; set; }
    }
}
