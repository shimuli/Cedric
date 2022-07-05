using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Customeraged
    {
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public double? Zeroage { get; set; }
        public double? Thirtyage { get; set; }
        public double? Sixtyage { get; set; }
        public double? Ninetyage { get; set; }
        public double? Creditlimit { get; set; }
        public double? Turnover { get; set; }
        public DateTime? Transdate { get; set; }
        public string Transtype { get; set; }
        public string Transdesc { get; set; }
        public string Transno { get; set; }
        public double? Docamount { get; set; }
        public string Username { get; set; }
        public int Entryno { get; set; }
        public double? Onetwentyage { get; set; }
        public double? Outstanding { get; set; }
        public string Debcred { get; set; }
        public int? Showpos { get; set; }
    }
}
