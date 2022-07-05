using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Glhist
    {
        public double? Olddr { get; set; }
        public double? Oldcr { get; set; }
        public double? Curdr { get; set; }
        public double? Curcr { get; set; }
        public string Period { get; set; }
        public string Acct { get; set; }
    }
}
