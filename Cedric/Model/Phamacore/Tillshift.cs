using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Tillshift
    {
        public int Tillno { get; set; }
        public string Tilluser { get; set; }
        public int Tillsessno { get; set; }
        public DateTime? Datein { get; set; }
        public DateTime? Timein { get; set; }
        public DateTime? Dateout { get; set; }
        public DateTime? Timeout { get; set; }
        public double? Tilltotal { get; set; }
        public bool? Killsess { get; set; }
        public double? Finaltill { get; set; }
        public double? Finalcash { get; set; }
        public int? Bcode { get; set; }
        public double? Cashintill { get; set; }
        public double? Cashinrecon { get; set; }
    }
}
