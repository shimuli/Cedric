using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SuppStatement
    {
        public int Id { get; set; }
        public string SuppCode { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransType { get; set; }
        public string Description { get; set; }
        public string Ref { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public double Balance { get; set; }
        public double Bfwd { get; set; }
        public int? Indexno { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public double? Docbal { get; set; }
        public double? Unallocated { get; set; }
        public double? ExchRate { get; set; }
        public int? Display { get; set; }
    }
}
