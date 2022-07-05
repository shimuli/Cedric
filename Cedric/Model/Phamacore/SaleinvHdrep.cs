using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SaleinvHdrep
    {
        public int SaleinvNum { get; set; }
        public string CusCode { get; set; }
        public string Memberno { get; set; }
        public DateTime SaleinvDate { get; set; }
        public DateTime? PayDue { get; set; }
        public string OrderNum { get; set; }
        public double? TradeDiscount { get; set; }
        public double? SaleinvVat { get; set; }
        public double? SaleinvD { get; set; }
        public double? SaleinvNet { get; set; }
        public short? CcontNum { get; set; }
        public double? SaleinvTotal { get; set; }
        public bool Batched { get; set; }
        public string SaleinvNumber { get; set; }
        public bool Done { get; set; }
        public int? TranspCode { get; set; }
        public double? Insure { get; set; }
        public int? WaybillNum { get; set; }
        public double? TranspCharge { get; set; }
        public string Comments { get; set; }
        public double? Amounttopay { get; set; }
        public double? Paid { get; set; }
        public double? Balance { get; set; }
        public double? Paying { get; set; }
        public string SalesCode { get; set; }
        public string CusRef { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Selected { get; set; }
        public string AnalysisCode { get; set; }
        public string UserName { get; set; }
        public string GlTradeaccount { get; set; }
        public double? TransportVat { get; set; }
        public double? MiscCharges { get; set; }
        public string Period { get; set; }
        public bool ItemselectionDone { get; set; }
        public DateTime? Lastupdate { get; set; }
        public short Printcopy { get; set; }
        public string BranchCode { get; set; }
        public string SaleinvRef { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public bool? Cashsaleinvoice { get; set; }
        public int? Lastlineno { get; set; }
        public bool? Urgent { get; set; }
        public int? Bcode { get; set; }
        public int? Invoicetype { get; set; }
        public bool? Bposted { get; set; }
    }
}
