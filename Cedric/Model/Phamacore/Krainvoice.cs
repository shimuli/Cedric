using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Krainvoice
    {
        public int Bcode { get; set; }
        public int SaleinvNum { get; set; }
        public string CusCode { get; set; }
        public string Doctype { get; set; }
        public string ResponseUrl { get; set; }
    }
}
