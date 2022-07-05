using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesAnalysisInventoryList
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public int? Receipt { get; set; }
        public int? OpBal { get; set; }
        public string InvStrength { get; set; }
        public string InvUnit { get; set; }
        public string InvSubgroupcode { get; set; }
        public string SubgroupName { get; set; }
        public string InvGroupcode { get; set; }
        public string GroupName { get; set; }
        public string ManufacturerCode { get; set; }
        public string ManufacturerName { get; set; }
        public string YearPlan { get; set; }
        public int? OnOrder { get; set; }
        public int CurrentStock { get; set; }
        public double InvAvgcost { get; set; }
        public int? Adjustments { get; set; }
        public int? GoodsReturned { get; set; }
        public int? Samples { get; set; }
        public int? CreditNotes { get; set; }
    }
}
