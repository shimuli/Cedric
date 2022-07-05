using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Ctlogz
    {
        public DateTime? Logdate { get; set; }
        public int Logid { get; set; }
        public string Loguser { get; set; }
        public int? Modulecode { get; set; }
        public string Modulename { get; set; }
        public string Modulearea { get; set; }
        public string Logerror { get; set; }
        public string Logerrorid { get; set; }
    }
}
