using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCustomerAgeAnalysisXtal11052005
    {
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string Username { get; set; }
        public double Thirtydays { get; set; }
        public double Sixtydays { get; set; }
        public double Ninetydays { get; set; }
        public double Uptothirty { get; set; }
        public double Onetwenty { get; set; }
        public decimal? AgeingTotal { get; set; }
        public double Creditlimit { get; set; }
        public double TotalSales { get; set; }
        public double? TotalDue { get; set; }
        public string Category { get; set; }
        public int CategoryCode { get; set; }
        public bool? Blocked { get; set; }
        public string ProvinceCode { get; set; }
        public string Province { get; set; }
        public string CscatgCode { get; set; }
        public string Description { get; set; }
    }
}
