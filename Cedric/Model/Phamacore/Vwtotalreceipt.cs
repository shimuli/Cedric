using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwtotalreceipt
    {
        public double Amountpaid { get; set; }
        public string BankAcct { get; set; }
        public string Gcode { get; set; }
        public DateTime? RptDate { get; set; }
        public DateTime? Clearingdate { get; set; }
    }
}
