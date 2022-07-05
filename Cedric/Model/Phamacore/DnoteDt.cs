using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class DnoteDt
    {
        public int DnoteNum { get; set; }
        public int DnoteDetNum { get; set; }
        public string InvCode { get; set; }
        public int Quantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double Totalcost { get; set; }
        public short DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public DateTime? Expiry { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public double LineDisc { get; set; }
        public int SaleinvDetNum { get; set; }
        public bool Applic { get; set; }
        public double Adjustment { get; set; }
        public double Oldtotalcost { get; set; }
        public double Oldprice { get; set; }
        public bool Dbatched { get; set; }
        public double Balance { get; set; }
    }
}
