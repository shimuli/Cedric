using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Denomination
    {
        public string DenominationCode { get; set; }
        public string Description { get; set; }
        public double? Valu { get; set; }
    }
}
