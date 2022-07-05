using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printstocktakeneo
    {
        public string InvCode { get; set; }
        public int Bcode { get; set; }
        public int Userdataid { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public int? Packsize { get; set; }
        public double? Instockunits { get; set; }
        public string Instockpw { get; set; }
        public double? Countunits { get; set; }
        public string Countpw { get; set; }
        public double? Varunits { get; set; }
        public string Varpw { get; set; }
        public string Branchname { get; set; }
    }
}
