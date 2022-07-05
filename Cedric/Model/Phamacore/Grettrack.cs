using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Grettrack
    {
        public string SinvNumber { get; set; }
        public string InvCode { get; set; }
        public int Taken { get; set; }
        public int Returned { get; set; }
        public int Gtrack { get; set; }
    }
}
