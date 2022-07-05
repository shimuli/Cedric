using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppAgeingDebitsMatched
    {
        public int SourceDocNum { get; set; }
        public string SourceDocType { get; set; }
        public DateTime TransDate { get; set; }
        public double Amount { get; set; }
        public string CusCode { get; set; }
    }
}
