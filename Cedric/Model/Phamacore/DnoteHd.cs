using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class DnoteHd
    {
        public int DnoteNum { get; set; }
        public string CusCode { get; set; }
        public DateTime DnoteDate { get; set; }
        public DateTime? PayDue { get; set; }
        public int SaleinvNum { get; set; }
        public double TradeDiscount { get; set; }
        public double DnoteVat { get; set; }
        public double DnoteD { get; set; }
        public double DnoteNet { get; set; }
        public short? CcontNum { get; set; }
        public double DnoteTotal { get; set; }
        public bool Batched { get; set; }
        public string DnoteNumber { get; set; }
        public string SaleinvNumber { get; set; }
        public string Comments { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Selected { get; set; }
        public double Paid { get; set; }
        public double Balance { get; set; }
        public string UserName { get; set; }
    }
}
