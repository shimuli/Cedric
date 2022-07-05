using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Mnfbmr
    {
        public int Bmrdet { get; set; }
        public int Bmrdetnum { get; set; }
        public int Bomdetnum { get; set; }
        public string MnfinvCode { get; set; }
        public string MnfinvName { get; set; }
        public string Mnfunit { get; set; }
        public double Mnfquantity { get; set; }
        public string Mnfpartwhole { get; set; }
        public double? Mnfpackqty { get; set; }
        public double? Mnfpwqty { get; set; }
        public DateTime? Mnfmanfdate { get; set; }
        public DateTime? Mnfexpdate { get; set; }
        public string Mnfbatchnum { get; set; }
        public string Mnfbatchsize { get; set; }
        public string Mnfpacksize { get; set; }
        public string LocCode { get; set; }
        public double? Qtyratio { get; set; }
    }
}
