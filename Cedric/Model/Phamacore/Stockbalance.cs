using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stockbalance
    {
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string InvUnit { get; set; }
        public string InvStrength { get; set; }
        public DateTime? TransDate { get; set; }
        public int? QtyIn { get; set; }
        public int? QtyOut { get; set; }
        public int? OpeningBalance { get; set; }
        public int Entryno { get; set; }
        public string BatchNum { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? ModuleCode { get; set; }
        public string Area { get; set; }
        public int? RunningBalance { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string DocNumber { get; set; }
        public double? MyTotal { get; set; }
        public double? TotalCost { get; set; }
    }
}
