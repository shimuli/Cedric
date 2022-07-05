using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Acc0064
    {
        public int Id { get; set; }
        public int Documentlineid { get; set; }
        public int? Documentid { get; set; }
        public string Documentno { get; set; }
        public string Itemid { get; set; }
        public int? Itemgroupid { get; set; }
        public int? Itemtypeid { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public decimal? Quantity { get; set; }
        public bool? Integrated { get; set; }
        public string Salespersonid { get; set; }
        public string Refno { get; set; }
        public string Sourcedocumentno { get; set; }
        public DateTime? Transactiondate { get; set; }
        public string Userid { get; set; }
        public string Memo { get; set; }
        public string Customermessage { get; set; }
        public string WhsCdFrom { get; set; }
        public string WhsCdTo { get; set; }
        public DateTime? Documentdate { get; set; }
        public string Uomid { get; set; }
        public string Productcode { get; set; }
        public decimal? Unitprice { get; set; }
        public string Uomid1 { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Linetotal { get; set; }
        public decimal? Grandtotal { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
