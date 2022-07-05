using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class UserAudittrail
    {
        public int? EntryNo { get; set; }
        public string UserName { get; set; }
        public int? ModuleCode { get; set; }
        public string Activity { get; set; }
        public string Code { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? TransTime { get; set; }
        public string TableName { get; set; }
    }
}
