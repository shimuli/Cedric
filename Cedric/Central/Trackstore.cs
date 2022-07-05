using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Trackstore
    {
        public DateTime? Storedate { get; set; }
        public DateTime? Storetime { get; set; }
        public int Storenum { get; set; }
        public int Bcode { get; set; }
        public string Storecontrol { get; set; }
        public int SaleinvNum { get; set; }
        public double? Storeweight { get; set; }
        public string Removedby { get; set; }
        public string Remarks { get; set; }
        public bool? Batched { get; set; }
        public DateTime? Storestarttime { get; set; }
        public DateTime? Storestartdate { get; set; }
        public double? Storepackage { get; set; }
        public string Storeturnaround { get; set; }
        public bool? Sameascontrol { get; set; }
        public int Doctype { get; set; }
        public int? Hrsid { get; set; }
        public int? Mutliselnum { get; set; }
        public string Hrsname { get; set; }
        public int? Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
    }
}
