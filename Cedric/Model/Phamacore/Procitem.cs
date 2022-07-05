using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Procitem
    {
        public int ProcCode { get; set; }
        public string InvCode { get; set; }
        public double? Qty { get; set; }
        public string Partwhole { get; set; }
        public double? Price { get; set; }
        public double? Total { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int Myzcounter { get; set; }
    }
}
