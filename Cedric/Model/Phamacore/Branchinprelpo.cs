using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Branchinprelpo
    {
        public int Prelponum { get; set; }
        public int Prelpobcode { get; set; }
        public int BorderNum { get; set; }
        public int BranchId { get; set; }
        public int InDetNum { get; set; }
        public string ItemCode { get; set; }
        public double? Prelpoqty { get; set; }
        public string Prelpoqtypw { get; set; }
        public string SuppCode { get; set; }
        public int? PorderNum { get; set; }
        public int? Porderbcode { get; set; }
        public int? PorderDetNum { get; set; }
        public string PorderNumber { get; set; }
        public bool? Spvcomplete { get; set; }
    }
}
