using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Expacct
    {
        public string Acct { get; set; }
        public string Des { get; set; }
        public string Type { get; set; }
        public string Typename { get; set; }
        public string Class { get; set; }
        public string Classname { get; set; }
        public string Bdgtcat { get; set; }
        public string Rptcat { get; set; }
        public string Rptdescription { get; set; }
        public bool? Bank { get; set; }
        public bool? Systemacct { get; set; }
        public bool? Controlacct { get; set; }
        public string Acctcatgcode { get; set; }
        public string Acctcatgname { get; set; }
        public int? Acctstartacct { get; set; }
        public int? Acctendacct { get; set; }
        public string Mthacct { get; set; }
        public bool? Motheracct { get; set; }
        public bool? Oldacct { get; set; }
        public bool? Hassubacct { get; set; }
        public bool? Subacct { get; set; }
        public bool? Tillgl { get; set; }
        public bool? Selme { get; set; }
        public string Invuser { get; set; }
    }
}
