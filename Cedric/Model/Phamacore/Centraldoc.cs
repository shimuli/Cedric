using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Centraldoc
    {
        public string Docname { get; set; }
        public int Modcode { get; set; }
        public int Bcode { get; set; }
        public double? Dtcount { get; set; }
        public double? Hdcount { get; set; }
        public DateTime Docsdate { get; set; }
        public bool? Docsclosed { get; set; }
    }
}
