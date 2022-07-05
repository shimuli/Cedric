using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesorderHd
    {
        public int SoNum { get; set; }
        public string CusCode { get; set; }
        public string Memberno { get; set; }
        public DateTime? SoDate { get; set; }
        public DateTime? ExpDelivery { get; set; }
        public string CusRef { get; set; }
        public double? TradeDiscount { get; set; }
        public double? SoVat { get; set; }
        public double? SoD { get; set; }
        public double? SoNet { get; set; }
        public short? CcontNum { get; set; }
        public double? SoTotal { get; set; }
        public bool Batched { get; set; }
        public string SoNumber { get; set; }
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
        public string DocDestination { get; set; }
        public string CsaleNumber { get; set; }
        public string CustomerName { get; set; }
    }
}
