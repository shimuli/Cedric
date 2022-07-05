using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CnoteHd
    {
        public int CnoteNum { get; set; }
        public int Bcode { get; set; }
        public string CusCode { get; set; }
        public DateTime? CnoteDate { get; set; }
        public DateTime? PayDue { get; set; }
        public int? SaleinvNum { get; set; }
        public double TradeDiscount { get; set; }
        public double CnoteVat { get; set; }
        public double CnoteD { get; set; }
        public double CnoteNet { get; set; }
        public short? CcontNum { get; set; }
        public double? CnoteTotal { get; set; }
        public bool Batched { get; set; }
        public string CnoteNumber { get; set; }
        public string SaleinvNumber { get; set; }
        public string Comments { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public string SalesCode { get; set; }
        public bool Selected { get; set; }
        public double Usin { get; set; }
        public double Balance { get; set; }
        public string UserName { get; set; }
        public bool Existingitems { get; set; }
        public int? TranspCode { get; set; }
        public short? Insure { get; set; }
        public int? WaybillNum { get; set; }
        public double TranspCharge { get; set; }
        public string AnalysisCode { get; set; }
        public double TransportVat { get; set; }
        public double MiscCharges { get; set; }
        public string GlTradeaccount { get; set; }
        public string Period { get; set; }
        public bool Cashsale { get; set; }
        public string PrevNumber { get; set; }
        public int? Documenttype { get; set; }
        public bool? Pricediff { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public int? Printcopy { get; set; }
        public int? Lastlineno { get; set; }
        public bool? Bposted { get; set; }
        public string CusRef { get; set; }
        public bool? Refund { get; set; }
        public int? Cuspoints { get; set; }
        public string Memberno { get; set; }
        public string Clcoredoc { get; set; }
        public bool? Clcoreclosed { get; set; }
        public int? Clvisit { get; set; }
        public double? CnoteExcise { get; set; }
        public int? Tillno { get; set; }
        public int? Tillsessno { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
        public bool? Refundcash { get; set; }
        public int? Cashrefundstatus { get; set; }
        public int? Rptdetnum { get; set; }
        public int? Rptbcode { get; set; }
        public int? Paydetnum { get; set; }
        public int? Paybcode { get; set; }
        public bool? Copaycnote { get; set; }
        public int? CopaycnoteNum { get; set; }
        public int? CopaycnoteBcode { get; set; }
        public int? Smartid { get; set; }
        public double? Mempointsbuy { get; set; }
        public double? Mempointsredeem { get; set; }
        public int? Loynum { get; set; }
        public int? Loybcode { get; set; }
    }
}
