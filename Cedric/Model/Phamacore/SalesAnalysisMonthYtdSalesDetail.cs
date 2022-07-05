using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesAnalysisMonthYtdSalesDetail
    {
        public int SaleinvNum { get; set; }
        public DateTime SaleinvDate { get; set; }
        public string InvCode { get; set; }
        public string CusCode { get; set; }
        public string SalesCode { get; set; }
        public int CurrentMonthQty { get; set; }
        public double? CurrentMonthPrice { get; set; }
        public double CurrentMonthTotal { get; set; }
        public int CurrentMonthBookMark { get; set; }
        public int PriorMonthQty { get; set; }
        public double? PriorMonthPrice { get; set; }
        public double PriorMonthTotal { get; set; }
        public int PriorMonthBookMark { get; set; }
        public int CurrentYtdqty { get; set; }
        public double? CurrentYtdprice { get; set; }
        public double CurrentYtdtotal { get; set; }
        public int CurrentYtdbookMark { get; set; }
        public int LastYearMonthQty { get; set; }
        public double? LastYearMonthPrice { get; set; }
        public double LastYearMonthTotal { get; set; }
        public int LastYearMonthBookMark { get; set; }
        public int LastYearYtdqty { get; set; }
        public double? LastYearYtdprice { get; set; }
        public double LastYearYtdtotal { get; set; }
        public int LastYearYtdbookMark { get; set; }
        public DateTime? CurrentMonthStartDate { get; set; }
        public DateTime? CurrentMonthEndDate { get; set; }
        public DateTime? PriorMonthStartDate { get; set; }
        public DateTime? PriorMonthEndDate { get; set; }
        public string CurrentYtdstartDate { get; set; }
        public DateTime? CurrentYtdendDate { get; set; }
        public DateTime? LastYearMonthStartDate { get; set; }
        public DateTime? LastYearMonthEndDate { get; set; }
        public string LastYearYtdstartDate { get; set; }
        public DateTime? LastYearYtdendDate { get; set; }
        public int? BonusIssued { get; set; }
    }
}
