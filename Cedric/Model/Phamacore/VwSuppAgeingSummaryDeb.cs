using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppAgeingSummaryDeb
    {
        public string Username { get; set; }
        public string SuppCode { get; set; }
        public double? Uptothirty { get; set; }
        public double? Thirtydays { get; set; }
        public double? Sixtydays { get; set; }
        public double? NinetyDays { get; set; }
        public double? OneTwenty { get; set; }
        public DateTime? Curend { get; set; }
    }
}
