using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwGrnGretnote
    {
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public int Returned { get; set; }
        public int Taken { get; set; }
        public int? Balance { get; set; }
        public int SinvDetNum { get; set; }
        public int Bonus { get; set; }
        public string GrnNumber { get; set; }
    }
}
