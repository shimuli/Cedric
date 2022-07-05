using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BmtHd
    {
        public int BmtNum { get; set; }
        public int Bcode { get; set; }
        public DateTime BmtDate { get; set; }
        public string BmtinvCode { get; set; }
        public string BmtinvName { get; set; }
        public string Bmtunit { get; set; }
        public double Bmtquantity { get; set; }
        public string Bmtpartwhole { get; set; }
        public double? Bmtpackqty { get; set; }
        public double? Bmtpwqty { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double TradeDiscount { get; set; }
        public double BmtVat { get; set; }
        public double BmtTotal { get; set; }
        public double BmtNet { get; set; }
        public double BmtD { get; set; }
        public string BmtNumber { get; set; }
        public string SupRef { get; set; }
        public string Comments { get; set; }
        public bool Pending { get; set; }
        public string SinvNumber { get; set; }
        public bool Done { get; set; }
        public int Invtype { get; set; }
        public bool Batched { get; set; }
        public int Grntype { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public string PayTerms { get; set; }
        public bool Cancelled { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public string ContName { get; set; }
        public int? Lastlineno { get; set; }
        public string Branchcode { get; set; }
        public string Branchfrom { get; set; }
        public int? Printcopy { get; set; }
        public int? Bomdet { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
