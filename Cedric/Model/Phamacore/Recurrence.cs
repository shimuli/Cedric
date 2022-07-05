using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Recurrence
    {
        public int RecurrCode { get; set; }
        public int? RecurrType { get; set; }
        public int? Dailytype { get; set; }
        public int? Daily { get; set; }
        public int? Weeklytype { get; set; }
        public int? Weekly { get; set; }
        public bool? Weekmon { get; set; }
        public bool? Weektue { get; set; }
        public bool? Weekwed { get; set; }
        public bool? Weekthu { get; set; }
        public bool? Weekfri { get; set; }
        public bool? Weeksat { get; set; }
        public bool? Weeksun { get; set; }
        public int? Monthlytype { get; set; }
        public int? Mday { get; set; }
        public int? Monthmonth { get; set; }
        public int? Monthfirst { get; set; }
        public int? Monthday { get; set; }
        public int? Monthmonth1 { get; set; }
        public int? Yearlytype { get; set; }
        public int? Yearmonth { get; set; }
        public int? Yday { get; set; }
        public int? Yearfirst { get; set; }
        public int? Yearday { get; set; }
        public int? Yearmonth1 { get; set; }
        public int? Rangetype { get; set; }
        public DateTime? Startrecurr { get; set; }
        public DateTime? Endrecurr { get; set; }
        public int? Endafter { get; set; }
    }
}
