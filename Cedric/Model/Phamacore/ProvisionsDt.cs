using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ProvisionsDt
    {
        public string ProvisionCode { get; set; }
        public string Glacctno { get; set; }
        public double? Provision { get; set; }
        public string Description { get; set; }
        public int Detnum { get; set; }
        public double? Fxprovision { get; set; }
        public bool Provtype { get; set; }
        public string Glexpenseacctcode { get; set; }
        public string Glexpenseacct { get; set; }
    }
}
