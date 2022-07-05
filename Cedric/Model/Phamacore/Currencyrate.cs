using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Currencyrate
    {
        public string Currencycode { get; set; }
        public int Period { get; set; }
        public string Year { get; set; }
        public double? ExchRate { get; set; }
        public bool Ratemultiply { get; set; }
        public int TransNum { get; set; }
    }
}
