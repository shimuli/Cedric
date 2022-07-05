using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class UsergroupRight
    {
        public string UserGroup { get; set; }
        public int ModuleCode { get; set; }
        public bool Status { get; set; }

        public virtual Sysmodule ModuleCodeNavigation { get; set; }
        public virtual UserGroup UserGroupNavigation { get; set; }
    }
}
