using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class AccountClass
    {
        public string AcctClass { get; set; }
        public string AcctType { get; set; }
        public string Description { get; set; }

        public virtual AccountType AcctTypeNavigation { get; set; }
    }
}
