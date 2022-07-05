using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesCode
    {
        public string AnalysisCode { get; set; }
        public string GlAcct { get; set; }
        public string Description { get; set; }
        public int? SaleReportid { get; set; }
        public int? CashReportid { get; set; }
        public bool? Hidden { get; set; }
    }
}
