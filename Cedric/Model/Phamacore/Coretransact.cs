using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Coretransact
    {
        public int Modcode { get; set; }
        public int Docnum { get; set; }
        public int Bcode { get; set; }
        public bool? Updateme { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
