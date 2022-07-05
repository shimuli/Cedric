using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Diagnosis
    {
        public string DiagCode { get; set; }
        public string DiagName { get; set; }
        public string DiagDesc { get; set; }
        public int Clinicode { get; set; }
        public int? DiagNum { get; set; }
    }
}
