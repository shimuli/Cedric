using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Selsistum
    {
        public string Username { get; set; }
        public string CusCode { get; set; }
        public string SuppCode { get; set; }
        public string InvCode { get; set; }
        public bool? Sel { get; set; }
        public string Cussup { get; set; }
        public int Detnum { get; set; }
        public string ManufacturerCode { get; set; }
        public string Branchcode { get; set; }
    }
}
