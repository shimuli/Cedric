using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CreditCategory
    {
        public string CreditCode { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double TradeDiscount { get; set; }
        public double? Pricemarkup { get; set; }
        public bool? Awardpoints { get; set; }
    }
}
