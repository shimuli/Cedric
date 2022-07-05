using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Unbatchlog
    {
        public string Username { get; set; }
        public string ModuleCode { get; set; }
        public string Docnum { get; set; }
        public DateTime? Docdate { get; set; }
        public string Docdescription { get; set; }
        public DateTime? Unbatchdate { get; set; }
        public int Transdet { get; set; }
    }
}
