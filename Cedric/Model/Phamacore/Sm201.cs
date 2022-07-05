using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Sm201
    {
        public int Areaid { get; set; }
        public string Areaname { get; set; }
        public bool? Admin1 { get; set; }
        public bool? Admin2 { get; set; }
        public bool? Admin3 { get; set; }
        public bool? Areauser { get; set; }
        public bool? Areacs { get; set; }
        public string Smessage { get; set; }
        public bool? Deactivate { get; set; }
        public double? Snvlimit { get; set; }
        public double? Cshlimit { get; set; }
        public double? Spvlimit { get; set; }
        public double? Cashierlimit { get; set; }
    }
}
