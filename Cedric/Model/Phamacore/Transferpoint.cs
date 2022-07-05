using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Transferpoint
    {
        public int EntryNo { get; set; }
        public string MemberNoFrom { get; set; }
        public string MemberNoTo { get; set; }
        public DateTime? TransferDate { get; set; }
        public double? TranferPoints { get; set; }
        public string Comments { get; set; }
        public bool? Posted { get; set; }
        public string UserName { get; set; }
    }
}
