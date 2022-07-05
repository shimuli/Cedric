using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwUnmatchedCustomerPayment
    {
        public string CusCode { get; set; }
        public string Currencycode { get; set; }
        public double? SumOfamountpaid { get; set; }
    }
}
