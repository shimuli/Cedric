using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwLastItemPriceSupp
    {
        public DateTime TransTime { get; set; }
        public string SuppCode { get; set; }
        public string InvCode { get; set; }
        public double Lastprice { get; set; }
        public double Lastdisc { get; set; }
        public string Partwhole { get; set; }
    }
}
