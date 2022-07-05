using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Billcalendar
    {
        public string BillNumber { get; set; }
        public int? BillCode { get; set; }
        public int BillNum { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Endtime { get; set; }
        public string Eventnotes { get; set; }
        public int? ReminderCode { get; set; }
        public int? RecurrCode { get; set; }
        public string Completenotes { get; set; }
        public bool? Disable { get; set; }
        public string Username { get; set; }
        public string Endtimecaption { get; set; }
        public string OrigEvent { get; set; }
    }
}
