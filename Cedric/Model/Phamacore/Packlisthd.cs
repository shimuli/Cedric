using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Packlisthd
    {
        public int Packlistno { get; set; }
        public string Packlistnumber { get; set; }
        public DateTime PackDate { get; set; }
        public int DocNum { get; set; }
        public string DocNumber { get; set; }
        public int ModuleCode { get; set; }
        public int? TranspCode { get; set; }
        public double? PackRate { get; set; }
        public double? TtlCarton { get; set; }
        public double? TtlWeight { get; set; }
        public string PackedBy { get; set; }
        public string CheckedBy { get; set; }
        public int? TtlLines { get; set; }
        public double? TtlCost { get; set; }
    }
}
