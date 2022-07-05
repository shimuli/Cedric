using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSalesAnalysisMonthYtdSalesDetailsSummary
    {
        public string InvCode { get; set; }
        public int CurrentMonthQty { get; set; }
        public double MonthTotalCurrentYear { get; set; }
        public double? CurrentMonthAvgPrice { get; set; }
        public int PriorMonthQty { get; set; }
        public double PriorMonthTotalCurrentYear { get; set; }
        public double? PriorMonthAvgPrice { get; set; }
        public int CurrentYtdqty { get; set; }
        public double YtdtotalCurrentYear { get; set; }
        public double? CurrentYtdavgPrice { get; set; }
        public int LastYearMonthQty { get; set; }
        public double MonthTotalLastYear { get; set; }
        public double? LastYearMonthAvgPrice { get; set; }
        public int LastYearYtdqty { get; set; }
        public double YtdtotalLastYear { get; set; }
        public double? LastYearYtdavgPrice { get; set; }
        public double? MonthSalesPercentageChange { get; set; }
        public double? YtdsalesPercentageChange { get; set; }
        public int? CurPriorMonthQtyPercentageChange { get; set; }
        public int? CurLastYearYtdqtyPercentageChange { get; set; }
        public int BonusIssued { get; set; }
    }
}
