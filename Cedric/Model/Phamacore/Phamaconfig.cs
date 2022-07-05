using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Phamaconfig
    {
        public string Phamaversion { get; set; }
        public string Phamaserial { get; set; }
        public double? Phamareg { get; set; }
        public string Clientmac { get; set; }
        public double? Phamausers { get; set; }
        public double? Phamademo { get; set; }
        public DateTime? Phamademoexpiry { get; set; }
    }
}
