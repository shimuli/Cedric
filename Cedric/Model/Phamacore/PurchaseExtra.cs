using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class PurchaseExtra
    {
        public int Id { get; set; }
        public string PorderNumber { get; set; }
        public string Indentno { get; set; }
        public DateTime? Indentdate { get; set; }
        public string Pfino { get; set; }
        public DateTime? Pfidate { get; set; }
        public string CustOrdnum { get; set; }
        public string Idfno { get; set; }
        public DateTime? Idfdate { get; set; }
        public DateTime? Idfexpiry { get; set; }
        public string Consignee { get; set; }
        public string Productcodeno { get; set; }
        public string Countryorigin { get; set; }
        public string Hsc { get; set; }
        public string Sitc { get; set; }
        public bool Preship { get; set; }
        public string Payterms { get; set; }
        public string Bankers { get; set; }
        public string Insuranceby { get; set; }
        public string Cifvalueplus { get; set; }
        public string Documents { get; set; }
        public string Shippingmarks { get; set; }
        public string Delivery { get; set; }
        public string Destination { get; set; }
        public int Bcode { get; set; }
    }
}
