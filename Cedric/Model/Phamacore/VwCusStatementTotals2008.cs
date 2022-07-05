using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCusStatementTotals2008
    {
        public string Username { get; set; }
        public string CusCode { get; set; }
        public double Thirtydays { get; set; }
        public double Sixtydays { get; set; }
        public double Ninetydays { get; set; }
        public double Uptothirty { get; set; }
        public double Onetwenty { get; set; }
        public double? TotalDue { get; set; }
        public double? CurrentTotal { get; set; }
        public int Unallocated { get; set; }
    }
}
