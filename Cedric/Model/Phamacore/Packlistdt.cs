using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Packlistdt
    {
        public int Packlistno { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double? Quantity { get; set; }
        public string Partwhole { get; set; }
        public double? PackCarton { get; set; }
        public double? PackWeight { get; set; }
        public string PackSize { get; set; }
        public double? PackTotalcost { get; set; }
        public int PackDetNum { get; set; }
        public int? PackLine { get; set; }
        public double? PackTotalweight { get; set; }
        public int? SaleinvDetNum { get; set; }
        public int? Mylineno { get; set; }
    }
}
