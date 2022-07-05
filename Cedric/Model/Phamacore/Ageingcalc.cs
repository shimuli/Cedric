using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Ageingcalc
    {
        public string CusCode { get; set; }
        public string Username { get; set; }
        public double Uptothirty { get; set; }
        public double Thirtydays { get; set; }
        public double Sixtydays { get; set; }
        public double Ninetydays { get; set; }
        public double Onetwenty { get; set; }
        public double Ccurr { get; set; }
        public double Cthirty { get; set; }
        public double Csixty { get; set; }
        public double Cninety { get; set; }
        public double Conetwenty { get; set; }
        public int Entrynum { get; set; }
    }
}
