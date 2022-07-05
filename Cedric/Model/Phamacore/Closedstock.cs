using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Closedstock
    {
        public string InvCode { get; set; }
        public int Stockmonth { get; set; }
        public int Stockyear { get; set; }
        public double? InvAvgcost { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public double? InvLastunitcost { get; set; }
    }
}
