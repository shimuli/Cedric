using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ExpcustomerMember
    {
        public string Memberno { get; set; }
        public string Membername { get; set; }
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public int CategoryCode { get; set; }
        public string Catgdescription { get; set; }
        public bool? Defcashinvoice { get; set; }
        public string Paymode { get; set; }
        public bool? Loyalty { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? MextraNum { get; set; }
        public int? SaluteCode { get; set; }
        public string Salutation { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public int? TownCode { get; set; }
        public string Twntown { get; set; }
        public string TwnprovinceCode { get; set; }
        public string Twnprovince { get; set; }
        public string Telephone { get; set; }
        public string Mxemail { get; set; }
        public string Cellphone { get; set; }
        public string Mxemail1 { get; set; }
        public string Doctor { get; set; }
        public string Doctorphone { get; set; }
        public string Contact { get; set; }
        public string Contactphone { get; set; }
        public string Allergies { get; set; }
        public string Notes { get; set; }
        public int? RecurrCode { get; set; }
        public DateTime? Memberdob { get; set; }
        public bool? Selme { get; set; }
        public string Invuser { get; set; }
    }
}
