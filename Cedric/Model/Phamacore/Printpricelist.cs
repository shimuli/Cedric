using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printpricelist
    {
        public string Itemcode { get; set; }
        public string ItemName { get; set; }
        public string PackSize { get; set; }
        public string Sbgroup { get; set; }
        public string PriceName { get; set; }
        public double? PriceValue { get; set; }
        public string UserName { get; set; }
        public string PriceName1 { get; set; }
        public double? PriceValue1 { get; set; }
        public string PriceName2 { get; set; }
        public double? PriceValue2 { get; set; }
        public string PriceName3 { get; set; }
        public double? PriceValue3 { get; set; }
        public string PriceName4 { get; set; }
        public double? PriceValue4 { get; set; }
        public string PriceName5 { get; set; }
        public double? PriceValue5 { get; set; }
        public double? Discount { get; set; }
        public double? BonusQty { get; set; }
        public double? BuyQty { get; set; }
        public DateTime? BonusExpiry { get; set; }
        public bool? Enabled { get; set; }
        public string ActiveIngredient { get; set; }
        public string PriceName6 { get; set; }
        public double? PriceValue6 { get; set; }
        public string PriceReportTitle { get; set; }
    }
}
