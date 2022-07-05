using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Sm200
    {
        public string Admin1cell { get; set; }
        public string Admin1name { get; set; }
        public string Admin2cell { get; set; }
        public string Admin2name { get; set; }
        public string Admin3cell { get; set; }
        public string Admin3name { get; set; }
        public byte[] TheApikey { get; set; }
        public byte[] TheSenderId { get; set; }
        public byte[] TheSmsrate { get; set; }
        public byte[] TheUserName { get; set; }
        public double? TheSmsbalance { get; set; }
        public double? TheSmscount { get; set; }
        public string TheSmsresponsePath { get; set; }
        public string Defcountry { get; set; }
        public string Admin1country { get; set; }
        public string Admin2country { get; set; }
        public string Admin3country { get; set; }
        public int? Nextsmsid { get; set; }
        public int? Freetextid { get; set; }
        public string TheApikeyRaw { get; set; }
        public string Smcompany { get; set; }
        public byte[] Otpkey { get; set; }
        public double? SmsbalanceAmount { get; set; }
        public DateTime? SmsbalanceDate { get; set; }
    }
}
