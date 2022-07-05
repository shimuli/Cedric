using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SlorderHd
    {
        public int SloNum { get; set; }
        public string CusCode { get; set; }
        public DateTime SloDate { get; set; }
        public DateTime? SloExpiry { get; set; }
        public double TradeDiscount { get; set; }
        public double SloVat { get; set; }
        public double SloD { get; set; }
        public short CcontNum { get; set; }
        public double SloNet { get; set; }
        public double SloTotal { get; set; }
        public string SloNumber { get; set; }
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
    }
}
