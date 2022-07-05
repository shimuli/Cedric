using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printstockcrosstab
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Manufacturername { get; set; }
        public double? Totalqty { get; set; }
        public double? Totalsales { get; set; }
        public string Username { get; set; }
        public string Myperiod { get; set; }
        public string Totalpartwhole { get; set; }
    }
}
