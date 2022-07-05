using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSupplierAgeAnalysisXtal
    {
        public string SuppCode { get; set; }
        public string SuppDesc { get; set; }
        public string Username { get; set; }
        public double? Thirtydays { get; set; }
        public double? Sixtydays { get; set; }
        public double? Ninetydays { get; set; }
        public double? Uptothirty { get; set; }
        public double? Onetwenty { get; set; }
        public double? AgeingTotal { get; set; }
        public double? Unallocated { get; set; }
        public double? Creditlimit { get; set; }
        public double? Pdcheques { get; set; }
        public double? TotalDue { get; set; }
        public bool? Blocked { get; set; }
        public string SpcatgCode { get; set; }
        public string SpcatgName { get; set; }
    }
}
