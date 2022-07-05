using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesMatrixSummary
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double? Total { get; set; }
        public double? Jan { get; set; }
        public double? Feb { get; set; }
        public double? Mar { get; set; }
        public double? Apr { get; set; }
        public double? May { get; set; }
        public double? Jun { get; set; }
        public double? Jul { get; set; }
        public double? Aug { get; set; }
        public double? Sep { get; set; }
        public double? Oct { get; set; }
        public double? Nov { get; set; }
        public double? De { get; set; }
        public string InvSubgroupcode { get; set; }
        public int? Salesyear { get; set; }
    }
}
