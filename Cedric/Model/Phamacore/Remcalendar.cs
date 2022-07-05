using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Remcalendar
    {
        public string RemndNumber { get; set; }
        public int? RemndCode { get; set; }
        public int RemndNum { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Endtime { get; set; }
        public string Eventnotes { get; set; }
        public int? ReminderCode { get; set; }
        public int? RecurrCode { get; set; }
        public string Completenotes { get; set; }
        public bool? Chkcomplete { get; set; }
        public string Username { get; set; }
        public string Endtimecaption { get; set; }
        public string OrigEvent { get; set; }
    }
}
