using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class StudentEmergyDetail
    {
        public StudentEmergyDetail()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Relation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Identification { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string InfoProvidedBy { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
