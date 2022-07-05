using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class User
    {
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public int Uid { get; set; }
        public string UserGroup { get; set; }
        public bool? Blocked { get; set; }
        public string Fullusername { get; set; }
        public string Usergrouplist { get; set; }
        public int? Pricescheme { get; set; }
        public int? Tillno { get; set; }
        public int? Tillsessno { get; set; }
        public string Xpass { get; set; }
        public string Userbranchlist { get; set; }
        public int? Passtry { get; set; }
        public bool? Passlockout { get; set; }
        public DateTime? Passtartdate { get; set; }
        public bool? Passexpired { get; set; }
        public string Cellname { get; set; }
        public string Cellnumber { get; set; }
        public string Cellcountry { get; set; }
    }
}
