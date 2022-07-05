using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class UserBranch
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual User User { get; set; }
    }
}
