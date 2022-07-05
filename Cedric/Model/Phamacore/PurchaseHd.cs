using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class PurchaseHd
    {
        public int PorderNum { get; set; }
        public DateTime PorderDate { get; set; }
        public string SuppCode { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double TradeDiscount { get; set; }
        public double PorderVat { get; set; }
        public double PorderTotal { get; set; }
        public double PorderNet { get; set; }
        public int ContNum { get; set; }
        public double PorderD { get; set; }
        public string PorderNumber { get; set; }
        public string SupRef { get; set; }
        public string Comments { get; set; }
        public bool Pending { get; set; }
        public string GrnNumber { get; set; }
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
        public int? Printcopy { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
        public int? Sbcode { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
        public int? Appstat { get; set; }
        public string Appuser { get; set; }
        public string Appcomments { get; set; }
    }
}
