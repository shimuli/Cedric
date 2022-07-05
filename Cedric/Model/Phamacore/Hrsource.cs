using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Hrsource
    {
        public int Hrsid { get; set; }
        public string Hrsfname { get; set; }
        public string Hrslname { get; set; }
        public string Cellname { get; set; }
        public string Cellnumber { get; set; }
        public string Cellcountry { get; set; }
        public string Hrsemail { get; set; }
        public string Hrsnatid { get; set; }
        public string Hrsdl { get; set; }
        public bool Instore { get; set; }
        public bool? Inverification { get; set; }
        public bool? Indispatch { get; set; }
        public bool? Indelivery { get; set; }
        public int? Hrsintext { get; set; }
        public bool? Indriver { get; set; }
    }
}
