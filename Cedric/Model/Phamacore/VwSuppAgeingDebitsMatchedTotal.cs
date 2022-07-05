using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppAgeingDebitsMatchedTotal
    {
        public int SourceDocNum { get; set; }
        public string SourceDocType { get; set; }
        public double? SumOfAmount { get; set; }
        public string CusCode { get; set; }
    }
}
