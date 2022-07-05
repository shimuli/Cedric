using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Itemdet
    {
        public string Item { get; set; }
        public string Location { get; set; }
        public double? Onhand { get; set; }
        public double? Onorder { get; set; }
        public double? Physical { get; set; }
        public double? Inqty { get; set; }
        public DateTime? Indate { get; set; }
        public double? Outqty { get; set; }
        public DateTime? Outdate { get; set; }
        public double? Adjqty { get; set; }
        public DateTime? Adjdate { get; set; }
        public double? MtdIssue { get; set; }
        public double? MtdRcpts { get; set; }
        public double? MtdAdj { get; set; }
        public double? YtdIssue { get; set; }
        public double? YtdRcpts { get; set; }
        public double? YtdAdj { get; set; }
        public string Comments { get; set; }
    }
}
