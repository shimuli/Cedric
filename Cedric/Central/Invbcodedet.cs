using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Invbcodedet
    {
        public string InvCode { get; set; }
        public int Bcode { get; set; }
        public string Storeid { get; set; }
        public string Storename { get; set; }
        public double? Stockqty { get; set; }
        public string Stockbatchnum { get; set; }
        public DateTime? Stockexpiry { get; set; }
        public int Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
        public int Invbcodedetref { get; set; }
        public int? Invbcodedetrowz { get; set; }
    }
}
