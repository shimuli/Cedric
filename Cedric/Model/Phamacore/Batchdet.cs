using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Batchdet
    {
        public string Id { get; set; }
        public string Invc { get; set; }
        public DateTime? Dat { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string Period { get; set; }
        public string Batch { get; set; }
        public string Des { get; set; }
        public bool Reversing { get; set; }
        public string Acct { get; set; }
        public int Myid { get; set; }
    }
}
