using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Payterm
    {
        public int Paytermcode { get; set; }
        public string Description { get; set; }
        public int? Numdays { get; set; }
        public int? DiscountedDays { get; set; }
        public double? Discount { get; set; }
        public double? InterestRate { get; set; }
        public int? ChargableAfter { get; set; }
    }
}
