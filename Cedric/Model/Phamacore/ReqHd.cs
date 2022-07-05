using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ReqHd
    {
        public int ReqNum { get; set; }
        public string IssueLoc { get; set; }
        public string ReceivingLoc { get; set; }
        public DateTime? ReqDate { get; set; }
        public DateTime? ExpDelivery { get; set; }
        public string ReqRef { get; set; }
        public double? TradeDiscount { get; set; }
        public double? ReqVat { get; set; }
        public double? ReqD { get; set; }
        public double? ReqNet { get; set; }
        public short? CcontNum { get; set; }
        public double? ReqTotal { get; set; }
        public bool Batched { get; set; }
        public string ReqNumber { get; set; }
        public string Comments { get; set; }
        public string SalesCode { get; set; }
        public bool Pending { get; set; }
        public string SaleinvNumber { get; set; }
        public bool Done { get; set; }
        public double? ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Cancelled { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public string Usermodify { get; set; }
        public bool? Wasbatched { get; set; }
        public int? PrqNum { get; set; }
        public int? Ibitype { get; set; }
        public int? Bincode1 { get; set; }
        public int? Bincode2 { get; set; }
        public int? Lastlineno { get; set; }
        public int? Printcopy { get; set; }
        public int? Bcode { get; set; }
        public bool? Docapprove { get; set; }
        public string Approveuser { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
        public string CusCode1 { get; set; }
        public string CusCode2 { get; set; }
        public string Cusname1 { get; set; }
        public string Cusname2 { get; set; }
    }
}
