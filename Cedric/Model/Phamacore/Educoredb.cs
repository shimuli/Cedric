using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Educoredb
    {
        public int ModuleCode { get; set; }
        public string Docname { get; set; }
        public string Docnumber { get; set; }
        public string Area { get; set; }
        public int TransNo { get; set; }
        public DateTime? Transdate { get; set; }
        public double? QtyIn { get; set; }
        public double? QtyOut { get; set; }
        public string InvCode { get; set; }
        public double? Totalcost { get; set; }
        public bool Batched { get; set; }
        public int? Searchcode { get; set; }
        public int Sortord { get; set; }
        public double? Bonus { get; set; }
        public double? Partquantity { get; set; }
        public int? Bcode { get; set; }
    }
}
