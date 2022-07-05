using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppStatementDetail
    {
        public string SuppCode { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransNo { get; set; }
        public double? CreditAmount { get; set; }
        public double? DebitAmount { get; set; }
        public string TransType { get; set; }
        public string TransDesc { get; set; }
    }
}
