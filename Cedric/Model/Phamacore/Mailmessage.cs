using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Mailmessage
    {
        public string Username { get; set; }
        public string Usermessage { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? SentTime { get; set; }
        public DateTime? RcvDate { get; set; }
        public DateTime? RcvTime { get; set; }
        public bool Rcvd { get; set; }
        public int Counter { get; set; }
        public string Sender { get; set; }
        public bool? Dismissed { get; set; }
        public bool? Sent { get; set; }
        public int? Msgnum { get; set; }
        public bool? Cc { get; set; }
    }
}
