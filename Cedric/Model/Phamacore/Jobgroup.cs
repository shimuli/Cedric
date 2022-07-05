using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Jobgroup
    {
        public int JgCode { get; set; }
        public string JgName { get; set; }
        public double? OtRate { get; set; }
        public double? SpRate { get; set; }
    }
}
