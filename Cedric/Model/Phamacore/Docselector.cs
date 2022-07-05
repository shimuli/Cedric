using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Docselector
    {
        public int Modcode { get; set; }
        public int Docdetnum { get; set; }
        public int Docbcode { get; set; }
        public string Docuser { get; set; }
        public bool? Docsel { get; set; }
        public string Adjcode { get; set; }
        public string Adjname { get; set; }
        public DateTime? Adjdate { get; set; }
    }
}
