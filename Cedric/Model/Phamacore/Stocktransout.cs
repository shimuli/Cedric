using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stocktransout
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
        public double QtyOut { get; set; }
        public bool? Posted { get; set; }
        public int? InstkNum { get; set; }
        public int? Instkentryno { get; set; }
        public string Username { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int? Bcode { get; set; }
        public DateTime? Savetime { get; set; }
        public int? Stkref { get; set; }
    }
}
