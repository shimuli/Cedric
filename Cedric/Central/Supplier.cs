using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Supplier
    {
        public string SuppCode { get; set; }
        public string Address { get; set; }
        public int? Bcode { get; set; }
        public bool? Blocked { get; set; }
        public string Cellcountry { get; set; }
        public string Cellname { get; set; }
        public string Cellnumber { get; set; }
        public double? Creditlimit { get; set; }
        public string Currencycode { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Physicaladd { get; set; }
        public string Pinno { get; set; }
        public string SpcatgCode { get; set; }
        public string SuppDesc { get; set; }
        public string Town { get; set; }
        public int? TownCode { get; set; }
        public string Vatno { get; set; }
    }
}
