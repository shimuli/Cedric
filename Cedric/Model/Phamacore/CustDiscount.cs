using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CustDiscount
    {
        public string CusCode { get; set; }
        public short? DiscountCode { get; set; }
        public int? Worthqty { get; set; }
        public int? Bonusdiscount { get; set; }
        public DateTime? Expirydate { get; set; }
    }
}
