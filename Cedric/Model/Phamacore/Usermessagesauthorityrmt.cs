using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Usermessagesauthorityrmt
    {
        public string Sender { get; set; }
        public int ModuleCode { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? SentTime { get; set; }
        public string Username { get; set; }
        public DateTime? RcvDate { get; set; }
        public DateTime? RcvTime { get; set; }
        public bool Rcvd { get; set; }
        public bool Updatemsg { get; set; }
        public bool Updatedone { get; set; }
        public int Counter { get; set; }
        public int? Authoritycode { get; set; }
        public int Authoritynum { get; set; }
        public bool Bposted { get; set; }
    }
}
