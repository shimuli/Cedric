using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Finalmovement
    {
        public string Stockcode { get; set; }
        public string Description { get; set; }
        public double InvLastunitcost { get; set; }
        public int InvMinqty { get; set; }
        public string Stockqty { get; set; }
        public string Instock { get; set; }
        public double InvInstockqty { get; set; }
        public double? Wqty { get; set; }
        public int? Pqty { get; set; }
        public int Spprice { get; set; }
        public int Spdisc { get; set; }
        public double? _201404 { get; set; }
        public double? _201403 { get; set; }
        public double? _201402 { get; set; }
        public double? _201401 { get; set; }
        public double? _201312 { get; set; }
        public double? _201311 { get; set; }
        public double? _201310 { get; set; }
        public double? _201309 { get; set; }
        public double? _201308 { get; set; }
        public double? _201307 { get; set; }
        public double? _201306 { get; set; }
        public double? _201305 { get; set; }
        public int? Zpack { get; set; }
    }
}
