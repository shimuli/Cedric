using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Ijrncode
    {
        public int Ijrntypenum { get; set; }
        public string Ijrntype { get; set; }
        public string Expenseacct { get; set; }
        public string Costofsalesacct { get; set; }
        public string Ijrnref { get; set; }
        public string Ijrndesc { get; set; }
        public bool? Attachgl { get; set; }
    }
}
