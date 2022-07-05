using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Trackcollectdispatch
    {
        public int Dispatchnum { get; set; }
        public int SaleinvNum { get; set; }
        public int Bcode { get; set; }
        public string Dispatchnumber { get; set; }
        public DateTime? Dispatchdate { get; set; }
        public string Dispatchcomments { get; set; }
        public int Dispatchdetnum { get; set; }
        public string Dispatchuser { get; set; }
        public int? CtCode { get; set; }
        public int? Routecode { get; set; }
        public int? Hrsiddrv { get; set; }
        public int? VehDeliveryid { get; set; }
        public bool? Dispbatched { get; set; }
        public int Collectnum { get; set; }
        public int Doctype { get; set; }
        public bool? Docrecall { get; set; }
    }
}
