using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Mpesahd
    {
        public int MpesaEntryNo { get; set; }
        public string Transid { get; set; }
        public DateTime? Transdate { get; set; }
        public TimeSpan? Transtime { get; set; }
        public double? Transamount { get; set; }
        public string Billrefnumber { get; set; }
        public string Cusphone { get; set; }
        public string Cusfname { get; set; }
        public string Cusmname { get; set; }
        public string Cuslname { get; set; }
        public int? Mpickno { get; set; }
        public int? Mpickbcode { get; set; }
        public int? RptDetnum { get; set; }
        public int? Rptbcode { get; set; }
        public string Transtype { get; set; }
        public string BusinessShortCode { get; set; }
        public int? MpesaConfirmNo { get; set; }
        public bool? Cashsale { get; set; }
        public int? Mpesadetno { get; set; }
        public int? Mpesareceiptready { get; set; }
        public int? Mpesareconauto { get; set; }
        public bool? Partpay { get; set; }
        public bool? Mpesacsale { get; set; }
    }
}
