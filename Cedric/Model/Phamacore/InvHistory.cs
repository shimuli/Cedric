using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvHistory
    {
        public int Id { get; set; }
        public string Transtype { get; set; }
        public string Narration { get; set; }
        public DateTime? TransDate { get; set; }
        public string Reference { get; set; }
        public int? Quantity { get; set; }
        public double? Cost { get; set; }
        public double? TotalCost { get; set; }
        public double? TotalSelling { get; set; }
        public string InvCode { get; set; }
    }
}
