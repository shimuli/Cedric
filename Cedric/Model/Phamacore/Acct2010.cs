using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Acct2010
    {
        public string Des { get; set; }
        public double Begdr { get; set; }
        public double Begcr { get; set; }
        public double Olddr { get; set; }
        public double Oldcr { get; set; }
        public double Curdr { get; set; }
        public double Curcr { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Bdgtcat { get; set; }
        public string Acct { get; set; }
        public double Prevdr { get; set; }
        public double Prevcr { get; set; }
        public string Rptcat { get; set; }
        public bool? Bank { get; set; }
        public bool? Systemacct { get; set; }
        public bool? Controlacct { get; set; }
        public double? Newbegdr { get; set; }
        public double? Newbegcr { get; set; }
        public bool? Blocked { get; set; }
        public string Acctcatgcode { get; set; }
        public string Mthacct { get; set; }
        public bool? Motheracct { get; set; }
        public bool? Oldacct { get; set; }
        public bool? Hassubacct { get; set; }
        public bool? Subacct { get; set; }
        public double? Oldbud { get; set; }
        public double? Begbud { get; set; }
        public double? Curbud { get; set; }
        public double? Prevbud { get; set; }
    }
}
