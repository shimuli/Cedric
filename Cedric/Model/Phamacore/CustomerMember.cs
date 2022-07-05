using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CustomerMember
    {
        public string Memberno { get; set; }
        public string CusCode { get; set; }
        public string Membername { get; set; }
        public double? Balance { get; set; }
        public bool Blocked { get; set; }
        public string Visitid { get; set; }
        public string Paymode { get; set; }
        public int? Cuspoints { get; set; }
        public int? Totalpoints { get; set; }
        public bool? Loyalty { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? Redeemed { get; set; }
        public int? MextraNum { get; set; }
        public double? Smartbalance { get; set; }
        public string Sce { get; set; }
        public int? SaluteCode { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public int? TownCode { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string Email1 { get; set; }
        public string Doctor { get; set; }
        public string Doctorphone { get; set; }
        public string Contact { get; set; }
        public string Contactphone { get; set; }
        public string Allergies { get; set; }
        public string Notes { get; set; }
        public int? RecurrCode { get; set; }
        public DateTime? Memberdob { get; set; }
        public string Cellname { get; set; }
        public string Cellnumber { get; set; }
        public string Cellcountry { get; set; }
        public bool? Issmart { get; set; }
        public bool? NoCopayLimit { get; set; }
        public string Memidno { get; set; }
        public double? Mempointsbal { get; set; }
        public double? Mempointsbuy { get; set; }
        public double? Mempointsredeem { get; set; }
        public int Kahtocode { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
