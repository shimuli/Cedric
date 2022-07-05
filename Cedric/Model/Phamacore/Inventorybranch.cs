using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Inventorybranch
    {
        public string InvCode { get; set; }
        public int Bcode { get; set; }
        public double InvInstockqty { get; set; }
        public int InvOpeningqty { get; set; }
        public int InvMinqty { get; set; }
        public int InvMaxqty { get; set; }
        public int InvReorderqty { get; set; }
    }
}
