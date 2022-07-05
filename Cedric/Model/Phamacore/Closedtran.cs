using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Closedtran
    {
        public int Bcode { get; set; }
        public int Modulecode { get; set; }
        public string Modulename { get; set; }
        public DateTime? Transdate { get; set; }
        public string Transperiod { get; set; }
        public int? Transcount { get; set; }
        public bool? Transposted { get; set; }
    }
}
