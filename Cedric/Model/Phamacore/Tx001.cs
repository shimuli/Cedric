using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Tx001
    {
        public string Txtype { get; set; }
        public string Txname { get; set; }
        public string TaxCode { get; set; }
        public string Txglacct { get; set; }
        public bool? Withholdvat { get; set; }
    }
}
