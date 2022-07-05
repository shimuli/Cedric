using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Trackdispatch
    {
        public DateTime? Dispdate { get; set; }
        public DateTime? Disptime { get; set; }
        public int Dispnum { get; set; }
        public string Dispcontrol { get; set; }
        public int? SaleinvNum { get; set; }
        public double? Dispweight { get; set; }
        public double? Disppackages { get; set; }
        public string Dispatchedby { get; set; }
        public string Remarks { get; set; }
        public bool? Batched { get; set; }
        public int? Packlistno { get; set; }
        public int? Bcode { get; set; }
        public DateTime? Dispstarttime { get; set; }
        public DateTime? Dispstartdate { get; set; }
        public string Dispturnaround { get; set; }
    }
}
