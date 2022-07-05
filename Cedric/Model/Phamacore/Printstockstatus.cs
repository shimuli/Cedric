using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printstockstatus
    {
        public string InvCode { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public string InvUnit { get; set; }
        public double? Quantity { get; set; }
        public DateTime? Stockdate { get; set; }
        public string PackQty { get; set; }
        public string Wholecount { get; set; }
    }
}
