using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BmtDt
    {
        public int BmtNum { get; set; }
        public int BmtDetNum { get; set; }
        public string InvCode { get; set; }
        public double Quantity { get; set; }
        public double Metquantity { get; set; }
        public double Remquantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public double Totalcost { get; set; }
        public short DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvStrength { get; set; }
        public double LineDisc { get; set; }
        public bool Detpending { get; set; }
        public double? Bonus { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int? Mylineno { get; set; }
        public DateTime? Entrydate { get; set; }
        public int? Bcode { get; set; }
        public string InvSubgroupname { get; set; }
        public int? Inclusive { get; set; }
        public double? Taxamt { get; set; }
        public double? Priceincl { get; set; }
    }
}
