using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwApplyReceiptTo
    {
        public int RptDetnum { get; set; }
        public string Gcs { get; set; }
        public string CusCode { get; set; }
        public string Gcode { get; set; }
        public string SuppCode { get; set; }
        public double Exchangerate { get; set; }
        public string Saleinvnumber { get; set; }
        public double OldExchangerate { get; set; }
        public string Customercurrency { get; set; }
        public string CurCurrency { get; set; }
        public int Bcode { get; set; }
        public int? Contrabcode { get; set; }
        public int Rptcounter { get; set; }
        public int RptNum { get; set; }
    }
}
