using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwGetReportName
    {
        public string ReportName { get; set; }
        public int Reportid { get; set; }
        public string ReportCategory { get; set; }
        public short? MaxLines { get; set; }
    }
}
