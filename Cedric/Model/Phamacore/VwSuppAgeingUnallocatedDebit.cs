using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppAgeingUnallocatedDebit
    {
        public string SuppCode { get; set; }
        public int DocNum { get; set; }
        public DateTime? SaleinvDate { get; set; }
        public int? NumDays { get; set; }
        public double? Bal { get; set; }
        public int Uptothirty { get; set; }
        public int Thirtydays { get; set; }
        public int Sixtydays { get; set; }
        public int Ninety { get; set; }
        public int OneTwenty { get; set; }
        public string TransDesc { get; set; }
        public double? Balance { get; set; }
        public string DocRef { get; set; }
        public double? Amount { get; set; }
        public string SourceDocType { get; set; }
    }
}
