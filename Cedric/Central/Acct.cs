using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Acct
    {
        public string Acct1 { get; set; }
        public string Des { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Bdgtcat { get; set; }
        public string Rptcat { get; set; }
        public bool? Bank { get; set; }
        public bool? Controlacct { get; set; }
        public bool? Blocked { get; set; }
        public int? Acctcatgcode { get; set; }
        public string Mthacct { get; set; }
        public bool? Motheracct { get; set; }
        public bool? Hassubacct { get; set; }
        public bool? Subacct { get; set; }
        public bool? Tillgl { get; set; }
        public int? Bcode { get; set; }
    }
}
