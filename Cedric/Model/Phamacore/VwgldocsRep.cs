using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwgldocsRep
    {
        public int ModuleCode { get; set; }
        public string Reference { get; set; }
        public string Cusname { get; set; }
        public int? Docnum { get; set; }
        public string Docnumber { get; set; }
        public string Doctype { get; set; }
        public string Scode { get; set; }
        public int Whichcode { get; set; }
        public double? Whichamt { get; set; }
        public string Cfromacc { get; set; }
        public string Cfromname { get; set; }
        public int? Bcode { get; set; }
    }
}
