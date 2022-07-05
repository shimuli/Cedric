using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwInventoryStatementDocBalance
    {
        public int ModuleCode { get; set; }
        public string Area { get; set; }
        public int TransNo { get; set; }
        public DateTime? Transdate { get; set; }
        public double? QtyIn { get; set; }
        public double? QtyOut { get; set; }
        public string InvCode { get; set; }
        public double? Totalcost { get; set; }
    }
}
