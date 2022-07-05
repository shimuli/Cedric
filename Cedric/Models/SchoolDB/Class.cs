using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class Class
    {
        public Class()
        {
            ClassSubjects = new HashSet<ClassSubject>();
            Students = new HashSet<Student>();
            TeacherClasses = new HashSet<TeacherClass>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? TotalStudents { get; set; }
        public int? MaxStudents { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Bcode { get; set; }
        public int? TeacherId { get; set; }
        public int StreamId { get; set; }

        public virtual ClassStream Stream { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<TeacherClass> TeacherClasses { get; set; }
    }
}
