using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CustCategory
    {
        public int CategoryCode { get; set; }
        public string Description { get; set; }
        public bool? Notregister { get; set; }
    }
}
