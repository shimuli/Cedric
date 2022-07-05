using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Userpasshistory
    {
        public string Username { get; set; }
        public int Uid { get; set; }
        public byte[] Password { get; set; }
        public int Passentrynum { get; set; }
    }
}
