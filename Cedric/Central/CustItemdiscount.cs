using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class CustItemdiscount
    {
        public string CusCode { get; set; }
        public string InvCode { get; set; }
        public double? CashDiscount { get; set; }
        public double? InvoiceDiscount { get; set; }
        public double? CashinvoiceDiscount { get; set; }
    }
}
