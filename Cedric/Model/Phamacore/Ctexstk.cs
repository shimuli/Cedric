using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Ctexstk
    {
        public int Bcode { get; set; }
        public int EntryId { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }
        public string LocCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? QtyExpiring { get; set; }
        public string BatchNumber { get; set; }
        public string ItemName { get; set; }
        public int? ItmPack { get; set; }
        public string ItemCode { get; set; }
        public double InvAvgcost { get; set; }
        public double? Calccost { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
