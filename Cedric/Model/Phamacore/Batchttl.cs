using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Batchttl
    {
        public string Batch { get; set; }
        public double? Total { get; set; }
        public double? Debits { get; set; }
        public double? Credits { get; set; }
        public DateTime? Dat { get; set; }
        public string Batchtype { get; set; }
        public string Period { get; set; }
        public bool Closing { get; set; }
        public bool Prnjrnl { get; set; }
    }
}
