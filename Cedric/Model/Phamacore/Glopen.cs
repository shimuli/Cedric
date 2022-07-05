using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Glopen
    {
        public string Id { get; set; }
        public string Invc { get; set; }
        public DateTime? Dat { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Period { get; set; }
        public string Batch { get; set; }
        public string Des { get; set; }
        public bool Closing { get; set; }
        public string Acct { get; set; }
        public int? ModuleCode { get; set; }
        public int? Transno { get; set; }
        public int? MyCounter { get; set; }
        public bool? Affected { get; set; }
        public bool? Systemgl { get; set; }
        public string SuppCode { get; set; }
        public string CusCode { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
