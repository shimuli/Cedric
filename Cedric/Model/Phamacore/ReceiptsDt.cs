using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ReceiptsDt
    {
        public string SaleinvNumber { get; set; }
        public DateTime? Dat { get; set; }
        public double? Amount { get; set; }
        public int Matchno { get; set; }
        public bool Normal { get; set; }
    }
}
