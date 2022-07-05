using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvGroup
    {
        public string InvGroupcode { get; set; }
        public string Description { get; set; }
        public string SalesGl { get; set; }
        public string CostofsalesGl { get; set; }
        public string InvadjustmentGl { get; set; }
        public string InventoryGl { get; set; }
        public string InvGroupbarcode { get; set; }
        public bool? Isacct { get; set; }
    }
}
