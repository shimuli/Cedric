using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Billreminder
    {
        public string BillNumber { get; set; }
        public int ReminderCode { get; set; }
        public bool? Dismiss { get; set; }
        public int Entrynum { get; set; }
        public DateTime? RemDate { get; set; }
        public DateTime? RemTime { get; set; }
        public int? RecurrCode { get; set; }
    }
}
