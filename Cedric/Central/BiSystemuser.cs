using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class BiSystemuser
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Timeout { get; set; }
        public bool Active { get; set; }
        public DateTime? Lastactivitydate { get; set; }
        public bool Isloggedin { get; set; }
        public string Registeredby { get; set; }
    }
}
