using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Paymaster
    {
        public string EdCode { get; set; }
        public string EmpNum { get; set; }
        public int PmNum { get; set; }
        public double Payamount { get; set; }
    }
}
