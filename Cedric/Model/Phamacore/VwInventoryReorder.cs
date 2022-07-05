using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwInventoryReorder
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public string InvUnit { get; set; }
        public int InvInstockqty { get; set; }
        public int? InvMinqty { get; set; }
        public int? InvMaxqty { get; set; }
        public int? SalesOrders { get; set; }
        public int? PurchaseOrders { get; set; }
        public int? ToOrder { get; set; }
    }
}
