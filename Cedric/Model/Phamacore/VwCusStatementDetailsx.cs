using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCusStatementDetailsx
    {
        public string CusCode { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransNo { get; set; }
        public double? DebitAmount { get; set; }
        public double? CreditAmount { get; set; }
        public string TransType { get; set; }
        public string TransDesc { get; set; }
        public string Status { get; set; }
    }
}
