using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class Supportstaff
    {
        public int Id { get; set; }
        public string TeacherNumber { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }
        public bool Disabled { get; set; }
        public string DisabilityType { get; set; }
        public string Pinnumber { get; set; }
        public DateTime Doe { get; set; }
        public string ContractType { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Qualification { get; set; }
        public string Citizenship { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AdditionalInfo { get; set; }
        public string NextKinFullName { get; set; }
        public string NextKinPhone { get; set; }
        public string NextKinEmail { get; set; }
        public string NextKinAddress { get; set; }
        public string NextKinAdditionalInfo { get; set; }
        public string PassportPhoto { get; set; }
        public string NationalIdcopy { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? Bcode { get; set; }

        public virtual Branch BcodeNavigation { get; set; }
    }
}
