using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Qpr
    {
        public string InvCode { get; set; }
        public string CusCode { get; set; }
        public double? Qprice { get; set; }
        public string Partwhole { get; set; }
    }
}
