using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ScreditDt
    {
        public int ScreditNum { get; set; }
        public int ScreditDetNum { get; set; }
        public string InvCode { get; set; }
        public int Quantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double Totalcost { get; set; }
        public short DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public string Description { get; set; }
        public string InvStrength { get; set; }
        public double LineDisc { get; set; }
        public int SinvDetNum { get; set; }
        public bool Applic { get; set; }
        public double Adjustment { get; set; }
        public double Oldtotalcost { get; set; }
        public double Oldprice { get; set; }
        public bool Dbatched { get; set; }
    }
}
