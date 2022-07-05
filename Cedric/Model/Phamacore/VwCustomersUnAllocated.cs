using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCustomersUnAllocated
    {
        public string Code { get; set; }
        public string CusName { get; set; }
        public double? Payments { get; set; }
        public double? CreditNotes { get; set; }
        public double? CreditJournals { get; set; }
        public double? Receipts { get; set; }
        public double? TotalToAllocate { get; set; }
        public string Choose { get; set; }
    }
}
