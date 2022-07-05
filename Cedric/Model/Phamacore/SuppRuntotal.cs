using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SuppRuntotal
    {
        public int Idkey { get; set; }
        public string SuppCode { get; set; }
        public DateTime? TransDate { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? SuppBal { get; set; }
        public int? Id { get; set; }
        public string Username { get; set; }
    }
}
