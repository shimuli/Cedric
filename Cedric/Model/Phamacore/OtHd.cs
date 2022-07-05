using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class OtHd
    {
        public string Prd { get; set; }
        public int Prdnum { get; set; }
        public int? Payyear { get; set; }
        public string EmpNum { get; set; }
        public int? OtNum { get; set; }
        public double? Ttlnohrs { get; set; }
        public double? Ttlsphrs { get; set; }
        public double? Norate { get; set; }
        public double? Sprate { get; set; }
        public double? Nototal { get; set; }
        public double? Sptotal { get; set; }
        public double? OtNet { get; set; }
        public double? OtBalance { get; set; }
        public int Transno { get; set; }
        public int Transtype { get; set; }
        public string EdCode { get; set; }
        public double? OtPaid { get; set; }
        public bool Posted { get; set; }
    }
}
