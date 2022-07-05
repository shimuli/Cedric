using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppAgeingSummaryDebit
    {
        public string SuppCode { get; set; }
        public double? Bal { get; set; }
        public double? Uptothirty { get; set; }
        public double? Thirtydays { get; set; }
        public double? Sixtydays { get; set; }
        public double? Ninety { get; set; }
        public double? OneTwenty { get; set; }
    }
}
