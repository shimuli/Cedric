using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Dip2020B
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public double? Stockqty { get; set; }
        public double? Avgcost { get; set; }
        public double? Stockvalue { get; set; }
    }
}
