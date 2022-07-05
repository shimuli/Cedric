using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSelectBank
    {
        public string BankAcct { get; set; }
        public string BankName { get; set; }
        public string BankGl { get; set; }
        public bool Postdated { get; set; }
        public string Currencycode { get; set; }
    }
}
