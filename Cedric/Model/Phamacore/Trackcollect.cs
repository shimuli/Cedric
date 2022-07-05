using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Trackcollect
    {
        public DateTime? Collectdate { get; set; }
        public DateTime? Collecttime { get; set; }
        public int Collectnum { get; set; }
        public string Collectcontrol { get; set; }
        public int? SaleinvNum { get; set; }
        public double? Collectweight { get; set; }
        public double? Collectpackages { get; set; }
        public string Collectedby { get; set; }
        public string Collectid { get; set; }
        public int? CtCode { get; set; }
        public int? CmCode { get; set; }
        public string Remarks { get; set; }
        public bool? Batched { get; set; }
        public int? Packlistno { get; set; }
        public int? Bcode { get; set; }
        public DateTime? Collectstarttime { get; set; }
        public DateTime? Collectstartdate { get; set; }
        public string Collectturnaround { get; set; }
        public string Dispatchedby { get; set; }
        public bool? Sameascontrol { get; set; }
        public int? VehCode { get; set; }
        public string VehMake { get; set; }
        public string VehReg { get; set; }
        public string VehDriver { get; set; }
        public string VehDriverid { get; set; }
        public int? Doctype { get; set; }
        public int? VehDeliveryid { get; set; }
        public int? Hrsid { get; set; }
        public int? Hrsiddrv { get; set; }
        public string SalesCode { get; set; }
        public int? TranspCode { get; set; }
        public int? Dispatchnum { get; set; }
        public bool? Dispatched { get; set; }
    }
}
