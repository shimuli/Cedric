using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwdaytransaction
    {
        public double Debamt { get; set; }
        public double Credamt { get; set; }
        public DateTime? Docdate { get; set; }
        public string Doctype { get; set; }
        public int Posn { get; set; }
    }
}
