using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Payperiodstatus
    {
        public string Theprd { get; set; }
        public int Theprdnum { get; set; }
        public bool? Locked { get; set; }
        public bool? Posted { get; set; }
        public int? Printcopy { get; set; }
        public string Themonth { get; set; }
        public int? Payyear { get; set; }
        public bool? Otlocked { get; set; }
    }
}
