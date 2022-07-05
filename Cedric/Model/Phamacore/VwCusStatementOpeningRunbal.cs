using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCusStatementOpeningRunbal
    {
        public string CusCode { get; set; }
        public DateTime? Transdate { get; set; }
        public string TransNo { get; set; }
        public double? DebitAmount { get; set; }
        public double? CreditAmount { get; set; }
        public string TransType { get; set; }
        public string TransDesc { get; set; }
        public string Status { get; set; }
        public double? Docbal { get; set; }
        public string Doctype { get; set; }
        public string TargetDocType { get; set; }
        public string Docnum { get; set; }
        public int ExchRate { get; set; }
        public int Display { get; set; }
    }
}
