using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Itembonusmulti
    {
        public string InvCode { get; set; }
        public double? Buyqty { get; set; }
        public double? Bonus { get; set; }
        public bool? Enablebonus { get; set; }
        public DateTime? Bonusexpiry { get; set; }
        public int Myxcounter { get; set; }
        public string AltinvCode { get; set; }
        public double? Altbonus { get; set; }
    }
}
