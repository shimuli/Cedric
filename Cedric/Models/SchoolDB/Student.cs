using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class Student
    {
        public Student()
        {
            ParentStudents = new HashSet<ParentStudent>();
        }

        public int Id { get; set; }
        public string StudentRegNum { get; set; }
        public string SchoolCode { get; set; }
        public string EnrollmentType { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Religion { get; set; }
        public string ParentsStatus { get; set; }
        public bool Disabled { get; set; }
        public string DisabilityType { get; set; }
        public string BloodGroup { get; set; }
        public string SpecialNeeds { get; set; }
        public string FormerSchool { get; set; }
        public string EntryMark { get; set; }
        public string DoctorName { get; set; }
        public string DoctorContact { get; set; }
        public string HospitalName { get; set; }
        public bool Scholarship { get; set; }
        public string ScholarshipType { get; set; }
        public string SponsorDetails { get; set; }
        public string SponsorPhone { get; set; }
        public string SponsorLocation { get; set; }
        public string SponsorContactPerson { get; set; }
        public string Citizenship { get; set; }
        public string HomeCounty { get; set; }
        public string SubCounty { get; set; }
        public string Residence { get; set; }
        public string EmergencyPhone { get; set; }
        public string StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public string PasswordImage { get; set; }
        public string BirthCert { get; set; }
        public DateTime DoA { get; set; }
        public int? EmergencyId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? ClassId { get; set; }
        public int? Bcode { get; set; }
        public string ProfileImage { get; set; }

        public virtual Branch BcodeNavigation { get; set; }
        public virtual Class Class { get; set; }
        public virtual StudentEmergyDetail Emergency { get; set; }
        public virtual ICollection<ParentStudent> ParentStudents { get; set; }
    }
}
