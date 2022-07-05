using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CusInterest
    {
        public string CusCode { get; set; }
        public DateTime? TransDate { get; set; }
        public string SaleinvNumber { get; set; }
        public double? InvoiceAmount { get; set; }
        public double? AmountPaid { get; set; }
        public double? InvoiceBalance { get; set; }
        public double? InterestRate { get; set; }
        public double? InterestCharged { get; set; }
        public bool Batched { get; set; }
    }
}
