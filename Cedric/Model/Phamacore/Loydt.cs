using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Loydt
    {
        public int Loynum { get; set; }
        public int Loybcode { get; set; }
        public int Loydetnum { get; set; }
        public double? Loydetsalevalue { get; set; }
        public double? Loydetpoints { get; set; }
        public int Loydettype { get; set; }
        public string Loydettypename { get; set; }
        public string Loydetitemcode { get; set; }
        public string Loydetitemname { get; set; }
    }
}
