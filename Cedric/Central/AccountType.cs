using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class AccountType
    {
        public AccountType()
        {
            AccountClasses = new HashSet<AccountClass>();
        }

        public string AcctType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AccountClass> AccountClasses { get; set; }
    }
}
