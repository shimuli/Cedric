using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwStockBalanceInquirydate
    {
        public string InvCode { get; set; }
        public double? Balance { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
