using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ItemCosting
    {
        public int? SalesModuleCode { get; set; }
        public int? SalesTransactionNo { get; set; }
        public int? SupplierModuleCode { get; set; }
        public int? SupplierTransactionNo { get; set; }
        public int TransactionNo { get; set; }
        public DateTime? TransDate { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public int QtyIssued { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public DateTime TransTime { get; set; }
    }
}
