using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvoiceMatchingRep
    {
        public int EntryNo { get; set; }
        public int Bcode { get; set; }
        public string SaleinvNumber { get; set; }
        public int SourceDocNum { get; set; }
        public string SourceDocRef { get; set; }
        public string SourceDocType { get; set; }
        public DateTime TransDate { get; set; }
        public double Amount { get; set; }
        public string TargetDocType { get; set; }
        public string CusCode { get; set; }
        public DateTime? TargetDate { get; set; }
        public bool? Bposted { get; set; }
    }
}
