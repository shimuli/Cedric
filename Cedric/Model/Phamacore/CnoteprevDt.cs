using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CnoteprevDt
    {
        public int SoNum { get; set; }
        public int SoDetNum { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Metquantity { get; set; }
        public int Remquantity { get; set; }
        public string TaxCode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double Totalcost { get; set; }
        public DateTime? Expiry { get; set; }
        public short DiscountCode { get; set; }
        public double Bonusdiscount { get; set; }
        public int Quantityused { get; set; }
        public string InvStrength { get; set; }
        public double LineDisc { get; set; }
        public bool? Detpending { get; set; }
        public int Bonus { get; set; }
        public string ItemCode { get; set; }
        public int PackQty { get; set; }
        public int TransferQty { get; set; }
        public int ReceiveQty { get; set; }
        public string ItemDesc { get; set; }
        public int PackqtyReceiving { get; set; }
        public string DefLoc { get; set; }
        public string GlAcct { get; set; }
        public double TaxAmt { get; set; }
    }
}
