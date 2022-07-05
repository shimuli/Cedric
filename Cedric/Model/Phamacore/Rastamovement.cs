using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Rastamovement
    {
        public string Stockcode { get; set; }
        public DateTime? SaleinvDate { get; set; }
        public double? Stockqty { get; set; }
        public double? Pwqty { get; set; }
    }
}
