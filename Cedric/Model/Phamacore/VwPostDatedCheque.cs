using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwPostDatedCheque
    {
        public string BankName { get; set; }
        public string BankAcct { get; set; }
        public string Currencycode { get; set; }
        public string BankGl { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public double? Amountpaid { get; set; }
        public bool Cleared { get; set; }
        public bool Batched { get; set; }
        public int RptDetnum { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Whichdoc { get; set; }
        public string Name { get; set; }
        public bool Holding { get; set; }
        public string Code { get; set; }
        public string Gcs { get; set; }
    }
}
