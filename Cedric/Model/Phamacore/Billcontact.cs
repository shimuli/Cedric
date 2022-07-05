using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Billcontact
    {
        public string BillNumber { get; set; }
        public int BillCode { get; set; }
        public string CreditCode { get; set; }
        public int? CategoryCode { get; set; }
        public string ProvinceCode { get; set; }
        public int? TownCode { get; set; }
        public string SalesCode { get; set; }
        public string CusCode { get; set; }
        public bool? Chkcomplete { get; set; }
        public string Completenotes { get; set; }
        public int Entrynum { get; set; }
    }
}
