using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Location
    {
        public string LocCode { get; set; }
        public int Bcode { get; set; }
        public string Description { get; set; }
        public string ContainerNo { get; set; }
        public string LaydownArea { get; set; }
        public string Branchlocation { get; set; }
        public bool Transit { get; set; }
        public bool? Rawmaterial { get; set; }
        public int? Prodclass { get; set; }
        public bool? Forcebins { get; set; }
    }
}
