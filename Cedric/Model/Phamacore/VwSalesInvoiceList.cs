using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSalesInvoiceList
    {
        public string CusCode { get; set; }
        public string SaleinvNumber { get; set; }
        public double? SaleinvNet { get; set; }
        public DateTime? PayDue { get; set; }
        public int? ChargableAfter { get; set; }
        public double? InterestRate { get; set; }
        public DateTime? DateInterestPayableFrom { get; set; }
    }
}
