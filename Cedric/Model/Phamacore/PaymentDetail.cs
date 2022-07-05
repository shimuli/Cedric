using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class PaymentDetail
    {
        public int? PayDetnum { get; set; }
        public double? Amount { get; set; }
        public string SinvNumber { get; set; }
        public string Reference { get; set; }
        public double Paycounter { get; set; }
        public int Entrynum { get; set; }
        public int Bcode { get; set; }
        public int PayNum { get; set; }
        public int? Sbcode { get; set; }
        public string Paynarration { get; set; }
        public double? BudgetAmt { get; set; }
        public int? Appstatus { get; set; }
        public bool? Bankcleared { get; set; }
        public DateTime? Clearingdate { get; set; }
        public double? SurrAmount { get; set; }
        public int? Votebooknum { get; set; }
        public int? Reqnopcash { get; set; }
        public int? Reqid { get; set; }
        public string PayGcs { get; set; }
        public int? ScJDetnum { get; set; }
        public int? ScJBcode { get; set; }
        public string PayCurrencycode { get; set; }
        public double? PayExchrate { get; set; }
        public double? XrateAmount { get; set; }
        public string AppNum { get; set; }
        public string PayName { get; set; }
        public int? Rptentrynum { get; set; }
        public bool? Revdoc { get; set; }
        public int? RptscJDetnum { get; set; }
        public int? RptscJBcode { get; set; }
        public string Comments { get; set; }
        public int? DeptCode { get; set; }
    }
}
