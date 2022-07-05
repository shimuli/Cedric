using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Customerledger
    {
        public string CusCode { get; set; }
        public DateTime? Transdate { get; set; }
        public string Transno { get; set; }
        public double? Debitamount { get; set; }
        public double? Creditamount { get; set; }
        public string Transtype { get; set; }
        public string Transdesc { get; set; }
        public double? Outstanding { get; set; }
        public bool? Batched { get; set; }
        public string Dcn { get; set; }
        public string Username { get; set; }
    }
}
