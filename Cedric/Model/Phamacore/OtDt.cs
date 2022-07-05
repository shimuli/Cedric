using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class OtDt
    {
        public string EmpNum { get; set; }
        public int OtNum { get; set; }
        public double Nohrs { get; set; }
        public double Sphrs { get; set; }
        public DateTime OtDate { get; set; }
        public int OtDetnum { get; set; }
        public string Prd { get; set; }
        public int? Prdnum { get; set; }
        public int? Payyear { get; set; }
        public int Transno { get; set; }
    }
}
