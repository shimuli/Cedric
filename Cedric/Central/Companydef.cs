using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Companydef
    {
        public string Companyname { get; set; }
        public string Finstartperiod { get; set; }
        public string Finendperiod { get; set; }
        public DateTime? Finstartdate { get; set; }
        public DateTime? Finenddate { get; set; }
        public DateTime? Suppagedate { get; set; }
        public DateTime? Cusagedate { get; set; }
    }
}
