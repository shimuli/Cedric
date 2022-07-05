using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BtrinHd
    {
        public int BtransNum { get; set; }
        public int Bcode { get; set; }
        public string Branchcode { get; set; }
        public string Branchfrom { get; set; }
        public DateTime BtransDate { get; set; }
        public DateTime? PayDue { get; set; }
        public string OrderNum { get; set; }
        public double? TradeDiscount { get; set; }
        public double? BtransVat { get; set; }
        public double? BtransD { get; set; }
        public double? BtransNet { get; set; }
        public short? CcontNum { get; set; }
        public double? BtransTotal { get; set; }
        public bool Batched { get; set; }
        public string BtransNumber { get; set; }
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
        public string BtransRef { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public bool? Cashsaleinvoice { get; set; }
        public int? Lastlineno { get; set; }
        public bool? Urgent { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
        public int? Bcodeto { get; set; }
        public int? Docscount { get; set; }
    }
}
