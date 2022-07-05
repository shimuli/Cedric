using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwQryLastPurchaseDate
    {
        public string InvCode { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
    }
}
