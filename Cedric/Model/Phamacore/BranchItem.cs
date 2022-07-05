using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BranchItem
    {
        public string Branchcode { get; set; }
        public string InvCode { get; set; }
        public double? Id { get; set; }
        public double? Price { get; set; }
        public bool? DiscountAvailable { get; set; }
        public double? Lastprice { get; set; }
        public double? Lastdiscount { get; set; }
        public double? PreferredPrice { get; set; }
        public int? LastOrdered { get; set; }
        public string InvCode1 { get; set; }
    }
}
