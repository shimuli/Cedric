using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvPrice
    {
        public string InvCode { get; set; }
        public string Pricecode { get; set; }
        public double? Amount { get; set; }
    }
}
