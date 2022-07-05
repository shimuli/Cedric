using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Borderlog
    {
        public int Bcode { get; set; }
        public int BorderNum { get; set; }
        public DateTime? BorderDate { get; set; }
        public int? Bordertobcode { get; set; }
        public string Bordertoname { get; set; }
        public bool? Override { get; set; }
        public DateTime? Overridedate { get; set; }
        public string Overridecomments { get; set; }
        public int Logref { get; set; }
    }
}
