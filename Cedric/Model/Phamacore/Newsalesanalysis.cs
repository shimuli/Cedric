using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Newsalesanalysis
    {
        public string Gpdesc { get; set; }
        public string Sbdesc { get; set; }
        public string Manf { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double Openbal { get; set; }
        public double Receipt { get; set; }
        public double Saleqty { get; set; }
        public double Salevalue { get; set; }
        public double Yearqty { get; set; }
        public double Yearvalue { get; set; }
        public double Closingqty { get; set; }
        public double InvAvgcost { get; set; }
        public double? Returned { get; set; }
        public double? Adjustment { get; set; }
        public double? Creditnotes { get; set; }
        public double? Bonus { get; set; }
    }
}
