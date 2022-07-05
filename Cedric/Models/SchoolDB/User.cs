using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class User
    {
        public User()
        {
            UserBranches = new HashSet<UserBranch>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public int? SchoolId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual SchoolDetail School { get; set; }
        public virtual ICollection<UserBranch> UserBranches { get; set; }
    }
}
