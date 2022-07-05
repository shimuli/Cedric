using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwgrn
    {
        public string GrnNumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public double Returned { get; set; }
        public double? Taken { get; set; }
        public double? Balance { get; set; }
        public int GrnDetNum { get; set; }
        public string Partwhole { get; set; }
        public string Partreturned { get; set; }
        public string Parttaken { get; set; }
        public string Partbalance { get; set; }
    }
}
