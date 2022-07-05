using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Town
    {
        public int TownCode { get; set; }
        public string Town1 { get; set; }
        public string ProvinceCode { get; set; }

        public virtual Province ProvinceCodeNavigation { get; set; }
    }
}
