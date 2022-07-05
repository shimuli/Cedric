using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Payrollitem
    {
        public string EdCode { get; set; }
        public string EdName { get; set; }
        public bool Systemacct { get; set; }
        public bool Taxacct { get; set; }
        public int EdType { get; set; }
        public int EdMode { get; set; }
        public double? EdAmount { get; set; }
        public string Acct { get; set; }
        public bool? Contribution { get; set; }
    }
}
