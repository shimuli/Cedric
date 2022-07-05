using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class DispenseHd
    {
        public int DispenseNum { get; set; }
        public string EmpNum { get; set; }
        public string Memberno { get; set; }
        public DateTime DispenseDate { get; set; }
        public DateTime? PayDue { get; set; }
        public string OrderNum { get; set; }
        public double? TradeDiscount { get; set; }
        public double? DispenseVat { get; set; }
        public double? DispenseD { get; set; }
        public double? DispenseNet { get; set; }
        public short? CcontNum { get; set; }
        public double? DispenseTotal { get; set; }
        public bool Batched { get; set; }
        public string DispenseNumber { get; set; }
        public bool Done { get; set; }
        public int? TranspCode { get; set; }
        public double? Insure { get; set; }
        public int? Drugt { get; set; }
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
        public string DispenseRef { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public bool? Cashsaleinvoice { get; set; }
        public int? Lastlineno { get; set; }
        public bool? Urgent { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
        public int? Invoicetype { get; set; }
        public int? Cuspoints { get; set; }
        public int? Redeemed { get; set; }
        public string RemndNumber { get; set; }
        public bool? Testcomplete { get; set; }
        public string Authorisedby { get; set; }
        public double? TtlWeight { get; set; }
        public int? Invtrack { get; set; }
        public double? DispenseExcise { get; set; }
        public string Clcoredoc { get; set; }
        public bool? Clcoreclosed { get; set; }
        public DateTime? Clcoreclosedate { get; set; }
        public int? Clvisit { get; set; }
        public int? Visitid { get; set; }
        public int? DependNo { get; set; }
        public bool? Clinic { get; set; }
        public int? Visitentrynum { get; set; }
        public int? Clcoredocnum { get; set; }
        public int? Tillno { get; set; }
        public int? Tillsessno { get; set; }
        public bool? Phamacore { get; set; }
    }
}
