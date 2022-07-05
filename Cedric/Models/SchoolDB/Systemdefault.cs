using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class Systemdefault
    {
        public int Id { get; set; }
        public string SmsuserId { get; set; }
        public string Smskey { get; set; }
        public string Smsname { get; set; }
        public int? NextTeacherNumber { get; set; }
        public string TeacherInitials { get; set; }
        public string StudentInitials { get; set; }
        public string SchoolName { get; set; }
        public string Logo { get; set; }
        public int? NextStaffNumber { get; set; }
        public string StaffInitials { get; set; }
    }
}
