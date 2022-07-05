using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            UsergroupRights = new HashSet<UsergroupRight>();
        }

        public string UserGroup1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UsergroupRight> UsergroupRights { get; set; }
    }
}
