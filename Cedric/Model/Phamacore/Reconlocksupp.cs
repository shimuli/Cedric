using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Reconlocksupp
    {
        public string Reconprd { get; set; }
        public bool? Posted { get; set; }
        public bool? Locked { get; set; }
        public int? Reconprdnum { get; set; }
        public int? Reconprdyear { get; set; }
        public DateTime? Reconprddate { get; set; }
        public DateTime? Recontransdate { get; set; }
        public string Reconby { get; set; }
        public string SuppCode { get; set; }
    }
}
