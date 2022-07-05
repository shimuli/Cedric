using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Trackstoremultisel
    {
        public int Multiselnum { get; set; }
        public int Multiselnumdet { get; set; }
        public int Bcode { get; set; }
        public int SaleinvNum { get; set; }
        public int Doctype { get; set; }
        public string Multiseluser { get; set; }
        public DateTime? Multiseldate { get; set; }
        public int? Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
    }
}
