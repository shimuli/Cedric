using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CsaleHdrep
    {
        public CsaleHdrep()
        {
            CsaleDtreps = new HashSet<CsaleDtrep>();
        }

        public int CsaleNum { get; set; }
        public DateTime CsaleDate { get; set; }
        public double? TradeDiscount { get; set; }
        public double? CsaleVat { get; set; }
        public double? CsaleD { get; set; }
        public double? CsaleNet { get; set; }
        public double? CsaleTotal { get; set; }
        public bool Batched { get; set; }
        public string Comments { get; set; }
        public string CsaleNumber { get; set; }
        public string CusCode { get; set; }
        public string CusRef { get; set; }
        public string Paymode { get; set; }
        public string BankAcct { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Reference { get; set; }
        public string CashCollector { get; set; }
        public string CustomerName { get; set; }
        public double? ExchRate { get; set; }
        public string Currencycode { get; set; }
        public string SalesCode { get; set; }
        public bool Cleared { get; set; }
        public bool Holding { get; set; }
        public bool Selected { get; set; }
        public double Cashpaid { get; set; }
        public double Cashbalance { get; set; }
        public string UserName { get; set; }
        public string AnalysisCode { get; set; }
        public string GlTradeaccount { get; set; }
        public bool BankCleared { get; set; }
        public DateTime? ClearingDate { get; set; }
        public bool ItemselectionDone { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string OrderNum { get; set; }
        public bool Cashsale { get; set; }
        public short Printcopy { get; set; }
        public double? Clearamt { get; set; }
        public int? RptDetnum { get; set; }
        public bool Cancelled { get; set; }
        public string Salesman { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public string LastCollector { get; set; }
        public string Memberno { get; set; }
        public int? Lastlineno { get; set; }
        public double? Cashfromcustomer { get; set; }
        public int? Cuspoints { get; set; }
        public int? Redeemed { get; set; }
        public string CusRef2 { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }

        public virtual ICollection<CsaleDtrep> CsaleDtreps { get; set; }
    }
}
