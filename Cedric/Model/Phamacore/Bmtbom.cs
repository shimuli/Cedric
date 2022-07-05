using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Bmtbom
    {
        public int Bomdet { get; set; }
        public int Bomdetnum { get; set; }
        public string BmtinvCode { get; set; }
        public string BmtinvName { get; set; }
        public string Bmtunit { get; set; }
        public double Bmtquantity { get; set; }
        public string Bmtpartwhole { get; set; }
        public double? Bmtpackqty { get; set; }
        public double? Bmtpwqty { get; set; }
        public int? Bcode { get; set; }
    }
}
