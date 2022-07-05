using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Trackverify
    {
        public DateTime? Verifdate { get; set; }
        public DateTime? Veriftime { get; set; }
        public int Verifnum { get; set; }
        public string Verifcontrol { get; set; }
        public int? SaleinvNum { get; set; }
        public double? Verifweight { get; set; }
        public double? Verifpackages { get; set; }
        public string Verifiedby { get; set; }
        public string Remarks { get; set; }
        public bool? Batched { get; set; }
        public int? Packlistno { get; set; }
        public int? Bcode { get; set; }
        public DateTime? Verifstarttime { get; set; }
        public DateTime? Verifstartdate { get; set; }
        public string Verifturnaround { get; set; }
        public bool? Sameascontrol { get; set; }
        public int? Doctype { get; set; }
        public int? Hrsid { get; set; }
    }
}
