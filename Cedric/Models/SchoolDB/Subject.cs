using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class Subject
    {
        public Subject()
        {
            ClassSubjects = new HashSet<ClassSubject>();
            SubjectUnits = new HashSet<SubjectUnit>();
        }

        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectIntials { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool HasUnits { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        public virtual ICollection<SubjectUnit> SubjectUnits { get; set; }
    }
}
