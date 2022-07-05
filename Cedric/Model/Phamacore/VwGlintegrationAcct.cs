using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwGlintegrationAcct
    {
        public string InvCode { get; set; }
        public string SalesGl { get; set; }
        public string InventoryGl { get; set; }
        public string CostofsalesGl { get; set; }
        public double InvAvgcost { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public string InvadjustmentGl { get; set; }
    }
}
