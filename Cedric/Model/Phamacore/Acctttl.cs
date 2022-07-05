using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Acctttl
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
        public double? Prevdr { get; set; }
        public double? Prevcr { get; set; }
    }
}
