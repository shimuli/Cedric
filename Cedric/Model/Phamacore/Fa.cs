using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Fa
    {
        public string Item { get; set; }
        public string Des { get; set; }
        public short? Life { get; set; }
        public string Method { get; set; }
        public string Vertex { get; set; }
        public DateTime? Acqdate { get; set; }
        public DateTime? Retdate { get; set; }
        public double? Cost { get; set; }
        public double? Basis { get; set; }
        public double? Salvage { get; set; }
        public double? Acumdepr { get; set; }
        public string Depracct { get; set; }
        public string Deprexp { get; set; }
        public string Tabl { get; set; }
        public double? Depramount { get; set; }
        public string Barcode { get; set; }
    }
}
