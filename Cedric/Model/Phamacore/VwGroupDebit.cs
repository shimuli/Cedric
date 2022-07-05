using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwGroupDebit
    {
        public string SaleinvNumber { get; set; }
        public string TargetDocType { get; set; }
        public double? Totaldebits { get; set; }
    }
}
