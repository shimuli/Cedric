using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class BiAuditTrail
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public DateTime Sysdate { get; set; }
        public string Activity { get; set; }
        public string Machinename { get; set; }
        public string Machineip { get; set; }
    }
}
