using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Province
    {
        public Province()
        {
            Towns = new HashSet<Town>();
        }

        public string ProvinceCode { get; set; }
        public string Province1 { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
