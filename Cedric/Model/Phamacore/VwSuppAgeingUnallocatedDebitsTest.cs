using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppAgeingUnallocatedDebitsTest
    {
        public string SuppCode { get; set; }
        public int DocNum { get; set; }
        public DateTime? SaleinvDate { get; set; }
        public double? Bal { get; set; }
        public int? NumDays { get; set; }
        public double? Uptothirty { get; set; }
        public double? Thirtydays { get; set; }
        public double? Sixtydays { get; set; }
        public double? Ninety { get; set; }
        public double? OneTwenty { get; set; }
        public string TransDesc { get; set; }
        public double Balance { get; set; }
        public string DocRef { get; set; }
        public double Amount { get; set; }
        public string SourceDocType { get; set; }
    }
}
