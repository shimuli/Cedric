using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printsalesdrill
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Manufacturername { get; set; }
        public double? Totalqty { get; set; }
        public double? Totalsales { get; set; }
        public string Username { get; set; }
        public string Subgroupname { get; set; }
        public double? Closingstock { get; set; }
    }
}
