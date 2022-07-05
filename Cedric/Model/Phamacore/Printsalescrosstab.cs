using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printsalescrosstab
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Manufacturername { get; set; }
        public double? Totalqty { get; set; }
        public double? Totalsales { get; set; }
        public string Username { get; set; }
        public string Myperiod { get; set; }
        public string Newcode { get; set; }
        public string Newname { get; set; }
        public int? Bcode { get; set; }
    }
}
