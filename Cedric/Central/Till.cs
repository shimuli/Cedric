using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Till
    {
        public int Tillno { get; set; }
        public int Bcode { get; set; }
        public bool? Tillactive { get; set; }
        public string Tilluser { get; set; }
        public int? Tillsessno { get; set; }
        public int? Nexttillsessno { get; set; }
        public string Tillname { get; set; }
        public double? Tillmaximum { get; set; }
        public string BankAcct { get; set; }
        public string Defusername { get; set; }
    }
}
