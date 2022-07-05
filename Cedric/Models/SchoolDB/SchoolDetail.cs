using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class SchoolDetail
    {
        public SchoolDetail()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string SchoolCode { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
