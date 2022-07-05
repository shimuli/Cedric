using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Contactcustomer
    {
        public int? CategoryCode { get; set; }
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public string Physicaladd { get; set; }
        public bool? Blocked { get; set; }
        public int? TownCode { get; set; }
        public string Companyfax { get; set; }
        public string Email { get; set; }
        public string Pin { get; set; }
        public string Vat { get; set; }
        public string Cusmemberno { get; set; }
        public string ContactNum { get; set; }
        public bool? Iscustomer { get; set; }
        public int? RatingCode { get; set; }
    }
}
