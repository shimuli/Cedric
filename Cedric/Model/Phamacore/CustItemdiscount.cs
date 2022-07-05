using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CustItemdiscount
    {
        public string CusCode { get; set; }
        public string InvCode { get; set; }
        public double? CashDiscount { get; set; }
        public double? InvoiceDiscount { get; set; }
        public DateTime? Expiry { get; set; }
        public double? Discount { get; set; }
        public double? CashinvoiceDiscount { get; set; }
    }
}
