using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwAgeingSummaryType1
    {
        public string CusCode { get; set; }
        public double? CurrentDebits { get; set; }
        public double? CurrentCredits { get; set; }
        public double? Uptothirty { get; set; }
        public double? Thirtydays { get; set; }
        public double? Sixtydays { get; set; }
        public double? Ninetydays { get; set; }
        public double? OneTwenty { get; set; }
    }
}
