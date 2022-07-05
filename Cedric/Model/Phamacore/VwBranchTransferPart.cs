using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwBranchTransferPart
    {
        public string BrinNumber { get; set; }
        public string Description { get; set; }
        public double Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public double Returned { get; set; }
        public double? Taken { get; set; }
        public double? Balance { get; set; }
        public int BrinDetNum { get; set; }
        public string Partwhole { get; set; }
        public string Partreturned { get; set; }
        public int Parttaken { get; set; }
        public string Partbalance { get; set; }
        public double? Partbalancepwqty { get; set; }
        public string Docsort { get; set; }
        public int? Bcodefrom { get; set; }
    }
}
