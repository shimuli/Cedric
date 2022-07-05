using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Usertimefootprint
    {
        public string Username { get; set; }
        public int Lognumber { get; set; }
        public DateTime? Timelog { get; set; }
        public string Transtype { get; set; }
        public string Transname { get; set; }
        public string Transdesc { get; set; }
    }
}
