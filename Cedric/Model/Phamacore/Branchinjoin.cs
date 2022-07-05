using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Branchinjoin
    {
        public string BorderNumber { get; set; }
        public int BorderNum { get; set; }
        public DateTime BorderDate { get; set; }
        public string BranchFrom { get; set; }
        public int? BranchId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double? ItemPack { get; set; }
        public double? OrdQty { get; set; }
        public string OrdPw { get; set; }
        public double OrdSuppl { get; set; }
        public string OrdSupplPw { get; set; }
        public double? OrdBal { get; set; }
        public string OrdBalPw { get; set; }
        public int DetNum { get; set; }
        public string BorderUser { get; set; }
        public double? ItemStock { get; set; }
        public string ItemStockPw { get; set; }
        public int? Bcode { get; set; }
        public int DocEntryNo { get; set; }
        public bool? Getsel { get; set; }
        public double? Orderqty { get; set; }
        public string Orderqtypw { get; set; }
        public double Varianceqty { get; set; }
        public string Varianceqtypw { get; set; }
        public int? Findme { get; set; }
        public int? InDetNum { get; set; }
        public string BranchFromCode { get; set; }
        public double? LineDisc { get; set; }
        public string TaxCode { get; set; }
    }
}
