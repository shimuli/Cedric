using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class BiRole
    {
        public int Roleid { get; set; }
        public string Rolename { get; set; }
        public string Roledescription { get; set; }
        public bool Active { get; set; }
        public int Userid { get; set; }
        public DateTime Sysdate { get; set; }
    }
}
