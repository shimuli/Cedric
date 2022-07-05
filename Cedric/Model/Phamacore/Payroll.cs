using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Payroll
    {
        public string EdCode { get; set; }
        public string EmpNum { get; set; }
        public int Prdnum { get; set; }
        public string Prd { get; set; }
        public int Payyear { get; set; }
        public int Transno { get; set; }
        public int PmNum { get; set; }
        public double Payamount { get; set; }
        public int? Transtype { get; set; }
        public int Paydet { get; set; }
        public bool? Posted { get; set; }
    }
}
