using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesanalysisYtd
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double? YearPlan { get; set; }
        public double? OnOrder { get; set; }
        public int? CurrentStock { get; set; }
        public double? MonthPlan { get; set; }
        public double? Ytdplan { get; set; }
        public double? AvgCost { get; set; }
        public double? CurrentMonthQty { get; set; }
        public double? MonthTotalCurrentYear { get; set; }
        public double? CurrentMonthAvgPrice { get; set; }
        public double? CostValue { get; set; }
        public double? SalesProfit { get; set; }
        public double? PriorMonthQty { get; set; }
        public double? PriorMonthTotalCurrentYear { get; set; }
        public double? PriorMonthAvgPrice { get; set; }
        public double? CurrentYtdqty { get; set; }
        public double? YtdtotalCurrentYear { get; set; }
        public double? CurrentYtdavgPrice { get; set; }
        public double? LastYearMonthQty { get; set; }
        public double? MonthTotalLastYear { get; set; }
        public double? LastYearMonthAvgPrice { get; set; }
        public double? LastYearYtdqty { get; set; }
        public double? YtdtotalLastYear { get; set; }
        public double? LastYearYtdavgPrice { get; set; }
        public double? MonthSalesPercentageChange { get; set; }
        public double? YtdsalesPercentageChange { get; set; }
        public double? CurPriorMonthQtyPercentageChange { get; set; }
        public double? CurPlanMonthQtyPercentageChange { get; set; }
        public double? CurLastYearYtdqtyPercentageChange { get; set; }
        public double? CurPlanYtdqtyPercentageChange { get; set; }
        public double? Receipt { get; set; }
        public double? OpBal { get; set; }
        public double? ClosingQty { get; set; }
        public double? SalesAvg { get; set; }
        public double? PeriodOrder { get; set; }
        public double? InventoryValue { get; set; }
        public int? BonusIssued { get; set; }
        public int? GoodsReturned { get; set; }
        public int? Adjustments { get; set; }
        public int? Samples { get; set; }
        public int? CreditNotes { get; set; }
    }
}
