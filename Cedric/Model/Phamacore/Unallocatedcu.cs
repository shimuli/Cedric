using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Unallocatedcu
    {
        public string Username { get; set; }
        public string CusCode { get; set; }
        public string Docnum { get; set; }
        public DateTime? Docdate { get; set; }
        public string Doctype { get; set; }
        public double? Docamount { get; set; }
        public double? Docbalance { get; set; }
        public int? Docdays { get; set; }
        public string Entrytype { get; set; }
        public string Docref { get; set; }
    }
}
