using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwgldocsBook
    {
        public int ModuleCode { get; set; }
        public string Reference { get; set; }
        public string Cusname { get; set; }
        public int? Docnum { get; set; }
        public string Docnumber { get; set; }
        public string Doctype { get; set; }
        public string Scode { get; set; }
        public double? Getpay { get; set; }
    }
}
