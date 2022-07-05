using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stktake
    {
        public DateTime? Stkdate { get; set; }
        public int Stkref { get; set; }
        public int? Stkcount { get; set; }
        public int? Stkupdatemode { get; set; }
        public int? Stkstatus { get; set; }
        public string LocCode { get; set; }
        public int? Bcode { get; set; }
        public bool? Batched { get; set; }
    }
}
