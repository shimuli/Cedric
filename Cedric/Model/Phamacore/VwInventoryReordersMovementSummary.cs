using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwInventoryReordersMovementSummary
    {
        public string InvCode { get; set; }
        public double Movement { get; set; }
        public int? OnOrder { get; set; }
    }
}
