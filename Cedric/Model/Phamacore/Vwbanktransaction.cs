using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwbanktransaction
    {
        public double Debamt { get; set; }
        public double Credamt { get; set; }
        public string BankAcct { get; set; }
        public DateTime? Docdate { get; set; }
    }
}
