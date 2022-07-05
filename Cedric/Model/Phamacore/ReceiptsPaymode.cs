using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ReceiptsPaymode
    {
        public int PmCode { get; set; }
        public int Paymodenum { get; set; }
        public int Paymodenumdet { get; set; }
        public int? RptDetnum { get; set; }
        public string Reference { get; set; }
        public double Amountpaid { get; set; }
        public int? Rptbcode { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Paymode { get; set; }
        public int? Cnotenum { get; set; }
        public int? Cnotebcode { get; set; }
        public int? Bcode { get; set; }
        public int? Mpickno { get; set; }
        public int? Mpickbcode { get; set; }
        public int? Mpesaentryno { get; set; }
        public string Mpesatransid { get; set; }
    }
}
