using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Docpriority
    {
        public string DocNumber { get; set; }
        public int ModuleCode { get; set; }
        public string CurrentUser { get; set; }
        public int? Priorityno { get; set; }
    }
}
