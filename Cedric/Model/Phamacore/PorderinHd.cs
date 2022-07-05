using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class PorderinHd
    {
        public int PorderinNum { get; set; }
        public DateTime PorderinDate { get; set; }
        public string SuppCode { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double TradeDiscount { get; set; }
        public double PorderinVat { get; set; }
        public double PorderinTotal { get; set; }
        public double PorderinNet { get; set; }
        public int ContNum { get; set; }
        public double PorderinD { get; set; }
        public string PorderinNumber { get; set; }
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
        public int Bcode { get; set; }
        public bool? Bposted { get; set; }
        public int? Sbcode { get; set; }
        public string CusCode { get; set; }
        public string Appuser { get; set; }
        public string Appcomments { get; set; }
        public int? Appstat { get; set; }
    }
}
