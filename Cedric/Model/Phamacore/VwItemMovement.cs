using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwItemMovement
    {
        public string InvCode { get; set; }
        public DateTime? Tdate { get; set; }
        public double? Movement { get; set; }
    }
}
