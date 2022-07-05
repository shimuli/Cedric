using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SuppDiscount
    {
        public string SuppCode { get; set; }
        public string InvCode { get; set; }
        public short? DiscountCode { get; set; }
        public int? Worthqty { get; set; }
        public double? Bonusdiscount { get; set; }
        public DateTime? Expirydate { get; set; }
        public int SdiscNum { get; set; }
    }
}
