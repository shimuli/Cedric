using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CnoteHdrep
    {
        public int CnoteNum { get; set; }
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
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
        public string CusRef { get; set; }
        public bool? Refund { get; set; }
    }
}
