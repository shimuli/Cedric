using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Branchinbtran
    {
        public string BorderNumber { get; set; }
        public int BorderNum { get; set; }
        public DateTime BorderDate { get; set; }
        public string BranchFrom { get; set; }
        public int BranchId { get; set; }
        public int? BtransNum { get; set; }
        public string BtransNumber { get; set; }
        public DateTime? BtransDate { get; set; }
        public int Bcode { get; set; }
        public string BorderUser { get; set; }
        public int? Autobtrnum { get; set; }
        public bool? Btrposted { get; set; }
    }
}
