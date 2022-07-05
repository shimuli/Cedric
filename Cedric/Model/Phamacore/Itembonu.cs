using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Itembonu
    {
        public string InvCode { get; set; }
        public double? Buyqty { get; set; }
        public double? Bonus { get; set; }
        public bool? Enablebonus { get; set; }
        public DateTime? Bonusexpiry { get; set; }
        public double? Steps { get; set; }
        public bool? Multilevel { get; set; }
    }
}
