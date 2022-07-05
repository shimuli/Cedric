using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class ProfileGroup
    {
        public string UserGroup { get; set; }
        public bool? ViewM { get; set; }
        public bool? AddM { get; set; }
        public bool? EditM { get; set; }
        public bool? DeleteM { get; set; }
        public bool? ProcessM { get; set; }
        public string ModuleName { get; set; }
        public int Ventrynum { get; set; }
    }
}
