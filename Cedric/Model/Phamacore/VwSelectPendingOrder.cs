using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSelectPendingOrder
    {
        public double? Pending { get; set; }
        public string InvCode { get; set; }
        public double InvInstockqty { get; set; }
    }
}
