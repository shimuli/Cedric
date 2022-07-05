using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Bordersetup
    {
        public int Bcode { get; set; }
        public double? Saledays { get; set; }
        public double? Saleperc { get; set; }
        public double? Orderdays { get; set; }
        public bool? Autofillhybrid { get; set; }
        public bool? Stockorderonly { get; set; }
        public bool? Excludenotsold { get; set; }
        public int? Daytorun { get; set; }
        public bool? Activate { get; set; }
        public DateTime? Lastrundate { get; set; }
        public int? Branchtobcode { get; set; }
        public string Branchtoname { get; set; }
        public DateTime? Nextrundate { get; set; }
        public bool? Forceautoorder { get; set; }
    }
}
