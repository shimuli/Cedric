using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stocktranstemp
    {
        public int StkNum { get; set; }
        public int Stkentryno { get; set; }
        public int ModuleCode { get; set; }
        public int? DocDetnum { get; set; }
        public int? DocNum { get; set; }
        public DateTime? DocDate { get; set; }
        public string InvCode { get; set; }
        public string BatchNum { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string LocCode { get; set; }
        public int QtyIn { get; set; }
        public int QtyOut { get; set; }
        public bool? Posted { get; set; }
    }
}
