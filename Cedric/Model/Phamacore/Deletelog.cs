using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Deletelog
    {
        public string Deleteuser { get; set; }
        public int? Docnum { get; set; }
        public string Docname { get; set; }
        public int? ModuleCode { get; set; }
        public DateTime? Deletedate { get; set; }
        public string Deletereason { get; set; }
        public DateTime? Transtime { get; set; }
    }
}
