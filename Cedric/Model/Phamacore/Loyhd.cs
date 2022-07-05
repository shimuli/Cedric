using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Loyhd
    {
        public int Loynum { get; set; }
        public int Loybcode { get; set; }
        public DateTime Loystartdate { get; set; }
        public DateTime Loyenddate { get; set; }
        public double Loyredeempoints { get; set; }
        public bool Loyactive { get; set; }
    }
}
