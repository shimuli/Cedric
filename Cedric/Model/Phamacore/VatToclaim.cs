using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VatToclaim
    {
        public int Counter { get; set; }
        public string TaxCode { get; set; }
        public DateTime? TransDate { get; set; }
        public string CusCode { get; set; }
        public string Description { get; set; }
        public string InvoiceNo { get; set; }
        public double? Amount { get; set; }
        public double? Vat { get; set; }
        public double? Total { get; set; }
        public bool Vatpaid { get; set; }
    }
}
