using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwUnmatchedSupplierPayment
    {
        public string SuppCode { get; set; }
        public string Currencycode { get; set; }
        public double? SumOfamountpaid { get; set; }
    }
}
