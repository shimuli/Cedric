using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Closingcost
    {
        public string InvCode { get; set; }
        public string Period { get; set; }
        public DateTime? Enddate { get; set; }
        public double InvAvgcost { get; set; }
    }
}
