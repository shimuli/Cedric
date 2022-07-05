using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCusStatementDetails2000
    {
        public string CusCode { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransNo { get; set; }
        public double? DebitAmount { get; set; }
        public double? CreditAmount { get; set; }
        public string TransType { get; set; }
        public string TransDesc { get; set; }
        public string Status { get; set; }
        public double? Docbal { get; set; }
        public double Unalloc { get; set; }
    }
}
