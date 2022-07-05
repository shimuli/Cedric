using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Usertimelog
    {
        public string Username { get; set; }
        public DateTime DateIn { get; set; }
        public int Lognumber { get; set; }
        public DateTime? TimeIn { get; set; }
        public bool? Autologout { get; set; }
        public DateTime? DateOut { get; set; }
        public DateTime? TimeOut { get; set; }
    }
}
