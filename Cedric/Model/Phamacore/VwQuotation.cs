using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwQuotation
    {
        public int QuoNum { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvCode { get; set; }
        public double Returned { get; set; }
        public double Taken { get; set; }
        public double? Balance { get; set; }
        public int QuoDetNum { get; set; }
        public string Partwhole { get; set; }
        public double Partstock { get; set; }
        public double Packqty { get; set; }
        public double Price { get; set; }
        public double? Bonbalance { get; set; }
    }
}
