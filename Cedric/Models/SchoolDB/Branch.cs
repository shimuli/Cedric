using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class Branch
    {
        public Branch()
        {
            Students = new HashSet<Student>();
            Supportstaffs = new HashSet<Supportstaff>();
            Teachers = new HashSet<Teacher>();
            UserBranches = new HashSet<UserBranch>();
        }

        public int Bcode { get; set; }
        public string BranchhName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Supportstaff> Supportstaffs { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<UserBranch> UserBranches { get; set; }
    }
}
