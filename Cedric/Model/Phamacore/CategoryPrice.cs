using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CategoryPrice
    {
        public string CreditCode { get; set; }
        public string InvCode { get; set; }
        public double? InvRetailprice { get; set; }
        public double? InvTradeprice { get; set; }
        public double? Discount { get; set; }
    }
}
