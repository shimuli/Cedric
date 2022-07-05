using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwGretnotePart
    {
        public string Description { get; set; }
        public double Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public double Returned { get; set; }
        public double? Taken { get; set; }
        public double? Balance { get; set; }
        public int SinvDetNum { get; set; }
        public double Bonus { get; set; }
        public string SinvNumber { get; set; }
        public string Partwhole { get; set; }
        public string Partreturned { get; set; }
        public string Parttaken { get; set; }
        public string Partbalance { get; set; }
    }
}
