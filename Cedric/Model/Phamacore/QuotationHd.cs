using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class QuotationHd
    {
        public int QuoNum { get; set; }
        public string CusCode { get; set; }
        public DateTime QuoDate { get; set; }
        public DateTime? QuoExpiry { get; set; }
        public double TradeDiscount { get; set; }
        public double QuoVat { get; set; }
        public double QuoD { get; set; }
        public short CcontNum { get; set; }
        public double QuoNet { get; set; }
        public double QuoTotal { get; set; }
        public string QuoNumber { get; set; }
        public string Comments { get; set; }
        public string SoNumber { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public string SalesCode { get; set; }
        public string Salesman { get; set; }
        public string ContName { get; set; }
        public int? Printcopy { get; set; }
        public string CusRef { get; set; }
        public int? Lastlineno { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
        public bool? Batched { get; set; }
        public string RemndNumber { get; set; }
        public string Memberno { get; set; }
        public int? Pricingmode { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
