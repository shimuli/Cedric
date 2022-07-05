using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwInventoryReordersMovement
    {
        public string InvCode { get; set; }
        public int SalesMonth { get; set; }
        public string MonthName { get; set; }
        public double? Movement { get; set; }
    }
}
