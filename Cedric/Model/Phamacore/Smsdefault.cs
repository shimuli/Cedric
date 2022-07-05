using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Smsdefault
    {
        public string SenderId { get; set; }
        public string SmsuserName { get; set; }
        public string Apikey { get; set; }
        public double? Smscount { get; set; }
        public double? SmsR { get; set; }
    }
}
