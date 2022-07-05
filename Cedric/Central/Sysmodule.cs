using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Sysmodule
    {
        public Sysmodule()
        {
            UsergroupRights = new HashSet<UsergroupRight>();
        }

        public int ModuleCode { get; set; }
        public string Modul { get; set; }
        public string Area { get; set; }
        public bool Loadable { get; set; }

        public virtual ICollection<UsergroupRight> UsergroupRights { get; set; }
    }
}
