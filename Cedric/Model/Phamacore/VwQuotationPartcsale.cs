using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwQuotationPartcsale
    {
        public int QuoNum { get; set; }
        public string Description { get; set; }
        public double Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public int Returned { get; set; }
        public double? Taken { get; set; }
        public double? Balance { get; set; }
        public int QuoDetNum { get; set; }
        public string Partwhole { get; set; }
        public double InvInstockqty { get; set; }
        public string Partreturned { get; set; }
        public string Parttaken { get; set; }
        public string Partbalance { get; set; }
        public double Packqty { get; set; }
        public string Partstock { get; set; }
    }
}
