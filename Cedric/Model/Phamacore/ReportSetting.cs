using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ReportSetting
    {
        public int Reportid { get; set; }
        public string ReportName { get; set; }
        public string Customer { get; set; }
        public string ReportHeaderTitle { get; set; }
        public string ReportPageTitle { get; set; }
        public short? TopMargin { get; set; }
        public short? BottomMargin { get; set; }
        public short? LeftMargin { get; set; }
        public short? RightMargin { get; set; }
        public short? ReportHeaderHeight { get; set; }
        public short? PageHeaderHeight { get; set; }
        public string ApplySettings { get; set; }
        public short? GroupFooterHeight { get; set; }
        public short? MinGroupFooterHeight { get; set; }
        public string ReportCategory { get; set; }
        public short? MaxLines { get; set; }
        public short? CustomerIndex { get; set; }
    }
}
