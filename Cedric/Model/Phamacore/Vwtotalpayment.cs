using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwtotalpayment
    {
        public double AmountPaid { get; set; }
        public string BankAcct { get; set; }
        public string Gcode { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? ClearingDate { get; set; }
    }
}
