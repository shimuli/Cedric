using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesAnalysisByItem
    {
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public string Unit { get; set; }
        public int? Qty { get; set; }
        public double? AvgPrice { get; set; }
        public double? Total { get; set; }
        public string Manufacturer { get; set; }
        public string TownCode { get; set; }
        public string Town { get; set; }
        public string ProvinceCode { get; set; }
        public string Province { get; set; }
        public string ManufacturerCode { get; set; }
    }
}
