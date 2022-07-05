using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesbudgetDatum
    {
        public double? SalesMonth { get; set; }
        public string MonthName { get; set; }
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double? Totalcost { get; set; }
        public int? Quantity { get; set; }
        public string InvSubgroupcode { get; set; }
        public int? Salesyear { get; set; }
    }
}
