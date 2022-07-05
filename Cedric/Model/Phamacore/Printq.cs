using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printq
    {
        public int SaleinvNum { get; set; }
        public string Username { get; set; }
        public bool? Printed { get; set; }
        public string Printedby { get; set; }
        public DateTime? Qdate { get; set; }
        public string BillNumber { get; set; }
        public string Errormessage { get; set; }
        public DateTime? Printdate { get; set; }
        public int Entrynum { get; set; }
    }
}
