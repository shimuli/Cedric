using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Glbudget
    {
        public string Invc { get; set; }
        public DateTime? Dat { get; set; }
        public decimal? Debitcredit { get; set; }
        public string Period { get; set; }
        public string Des { get; set; }
        public string Acct { get; set; }
        public int? ModuleCode { get; set; }
        public int? Transno { get; set; }
        public int MyBudgCounter { get; set; }
        public bool? Affected { get; set; }
        public bool? Systemgl { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
    }
}
