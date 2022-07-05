using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class IbiDt
    {
        public int IbiNum { get; set; }
        public int Bcode { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public int? Metquantity { get; set; }
        public int? Remquantity { get; set; }
        public double? Price { get; set; }
        public string Unit { get; set; }
        public double? Totalcost { get; set; }
        public int? OrdQuantity { get; set; }
        public bool? Detpending { get; set; }
        public int? Delivered { get; set; }
        public int? EntryDetnum { get; set; }
        public int? StkNum { get; set; }
        public int? InstkNum { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public DateTime? TransTime { get; set; }
        public int? Mylineno { get; set; }
        public int? ReqDetNum { get; set; }
        public int? RetDetNum { get; set; }
        public int? Bcoderet { get; set; }
        public bool? Ibireturn { get; set; }
        public int IbiDetNum { get; set; }
    }
}
