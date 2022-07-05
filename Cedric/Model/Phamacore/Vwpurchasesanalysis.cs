using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwpurchasesanalysis
    {
        public string TaxCode { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
        public DateTime? TransDate { get; set; }
        public string SuppCode { get; set; }
        public string InvoiceNo { get; set; }
        public double Price { get; set; }
        public double? Quantity { get; set; }
        public double? Grosssamt { get; set; }
        public double? Discount { get; set; }
        public double? Goodsamt { get; set; }
        public double? Vat { get; set; }
        public double? Total { get; set; }
        public string Name { get; set; }
        public string InvCode { get; set; }
        public string Itemname { get; set; }
        public string Docref { get; set; }
        public double Bonus { get; set; }
        public string TheDocname { get; set; }
        public int ThemoduleCode { get; set; }
        public double? Partquantity { get; set; }
        public string CusClass { get; set; }
        public string Suppcat { get; set; }
        public int? Bcode { get; set; }
        public int? DeptCode { get; set; }
    }
}
