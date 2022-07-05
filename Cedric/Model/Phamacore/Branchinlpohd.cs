using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Branchinlpohd
    {
        public int Prelponum { get; set; }
        public int Prelpobcode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double? ItemPack { get; set; }
        public double? Totalprelpoqty { get; set; }
        public string Totalprelpoqtypw { get; set; }
        public int? PorderNum { get; set; }
        public int? Porderbcode { get; set; }
        public int? PorderDetNum { get; set; }
        public string SuppCode { get; set; }
        public string SuppDesc { get; set; }
        public double? Spprice { get; set; }
        public double? Spdisc { get; set; }
        public string PorderNumber { get; set; }
        public bool? Spvcomplete { get; set; }
    }
}
