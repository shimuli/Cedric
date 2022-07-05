using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printlabel
    {
        public int Doctype { get; set; }
        public int Docnum { get; set; }
        public string Labelname { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string Strength { get; set; }
        public int? Quantity { get; set; }
        public string Patname { get; set; }
    }
}
