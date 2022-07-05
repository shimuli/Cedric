using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Usermessage
    {
        public string Username { get; set; }
        public string Usermessage1 { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? SentTime { get; set; }
        public DateTime? RcvDate { get; set; }
        public DateTime? RcvTime { get; set; }
        public bool Rcvd { get; set; }
        public bool Updatemsg { get; set; }
        public string Tblname { get; set; }
        public bool Updatedone { get; set; }
        public int Counter { get; set; }
        public string Sender { get; set; }
    }
}
