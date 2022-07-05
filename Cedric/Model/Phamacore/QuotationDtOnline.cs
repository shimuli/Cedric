﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class QuotationDtOnline
    {
        public int QuoNum { get; set; }
        public int Bcode { get; set; }
        public string InvCode { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string Strength { get; set; }
        public string Manuf { get; set; }
        public string TaxCode { get; set; }
        public double Totalcost { get; set; }
        public string Description { get; set; }
        public string Icode { get; set; }
        public bool An { get; set; }
        public double LineDisc { get; set; }
        public int? Mylineno { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public DateTime? Entrydate { get; set; }
        public int? Inclusive { get; set; }
        public double? Taxamt { get; set; }
        public double? Priceincl { get; set; }
        public double? Bonus { get; set; }
        public int? DeptCode { get; set; }
        public int QuoDetNum { get; set; }
    }
}
