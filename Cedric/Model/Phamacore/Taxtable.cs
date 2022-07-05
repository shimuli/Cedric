using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Taxtable
    {
        public string Incomebracket { get; set; }
        public string Taxontaaxableincome { get; set; }
        public double? Taxrate { get; set; }
        public double? Taxincome { get; set; }
        public int Taxpos { get; set; }
        public int? Payyear { get; set; }
    }
}
