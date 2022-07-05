using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Glbatch
    {
        public int? Batchid { get; set; }
        public int? Period { get; set; }
        public DateTime? TransDate { get; set; }
        public string Gdc { get; set; }
        public string AccountNo { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
        public int? TaxType { get; set; }
        public double? TaxAmount { get; set; }
        public string OpenitemType { get; set; }
        public string JobCode { get; set; }
        public bool? Posted { get; set; }
        public bool Posting { get; set; }
        public string Status { get; set; }
    }
}
