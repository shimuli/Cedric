using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Eventcontact
    {
        public string EventNumber { get; set; }
        public string ContactNum { get; set; }
        public bool? Chkcomplete { get; set; }
        public string Completenotes { get; set; }
        public int Entrynum { get; set; }
    }
}
