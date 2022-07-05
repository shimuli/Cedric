using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class TaxType
    {
        public string TaxCode { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
    }
}
