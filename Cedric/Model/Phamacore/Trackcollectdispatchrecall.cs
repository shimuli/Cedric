using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Trackcollectdispatchrecall
    {
        public string Dispatchnumber { get; set; }
        public int Recallref { get; set; }
        public int SaleinvNum { get; set; }
        public int Bcode { get; set; }
        public int Collectnum { get; set; }
        public DateTime? Recalldate { get; set; }
        public string Recallby { get; set; }
        public int Doctype { get; set; }
    }
}
