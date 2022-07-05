using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stockactivity
    {
        public int Periodnum { get; set; }
        public string Username { get; set; }
        public int? Periodmonthnum { get; set; }
        public string Periodmonthname { get; set; }
        public int? Periodyear { get; set; }
        public DateTime? LastsaleinvDate { get; set; }
        public DateTime? LastsinvDate { get; set; }
        public double? Purchqty { get; set; }
        public double? Adjqty { get; set; }
        public double? Salesqty { get; set; }
        public double? Onhandqty { get; set; }
        public double? Avgcost { get; set; }
        public double? Salesvalue { get; set; }
        public string InvCode { get; set; }
        public string InvName { get; set; }
        public int? InvPack { get; set; }
    }
}
