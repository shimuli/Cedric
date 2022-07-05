using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class StatementPeriodssupp
    {
        public string Period { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public short? Prplace { get; set; }
        public int? Sy { get; set; }
        public int? Ey { get; set; }
        public int? Leapy { get; set; }
        public DateTime? Leapenddate { get; set; }
    }
}
