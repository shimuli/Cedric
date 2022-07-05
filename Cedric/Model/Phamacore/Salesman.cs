using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Salesman
    {
        public string SalesCode { get; set; }
        public string Name { get; set; }
        public double? Scom { get; set; }
        public double? Daytarget { get; set; }
    }
}
