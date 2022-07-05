using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Gljrnbatch
    {
        public int Gljrnnum { get; set; }
        public DateTime? Gljrndate { get; set; }
        public string Gljrnref { get; set; }
        public string Gljrndesc { get; set; }
        public string Username { get; set; }
        public bool? Glposted { get; set; }
        public int Bcode { get; set; }
        public bool? Frompayroll { get; set; }
        public int? Companyid { get; set; }
    }
}
