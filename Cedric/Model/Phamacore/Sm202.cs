using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Sm202
    {
        public int Transid { get; set; }
        public int Areaid { get; set; }
        public string Smcontact { get; set; }
        public string Smessage { get; set; }
        public int? Smstatus { get; set; }
        public DateTime? Smdatesent { get; set; }
        public string Retstatus { get; set; }
        public DateTime? Retdate { get; set; }
    }
}
