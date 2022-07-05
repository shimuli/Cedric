using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Impcustomerauto
    {
        public int CategoryCode { get; set; }
        public string Catgdescription { get; set; }
        public bool? Catgnotregister { get; set; }
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public int? TownCode { get; set; }
        public string Twntown { get; set; }
        public string TwnprovinceCode { get; set; }
        public string Twnprovince { get; set; }
        public string Phone { get; set; }
        public string Physicaladd { get; set; }
        public string CreditCode { get; set; }
        public string Crddescription { get; set; }
        public double? Crddiscount { get; set; }
        public DateTime? CrdexpiryDate { get; set; }
        public double? CrdtradeDiscount { get; set; }
        public double? Crdpricemarkup { get; set; }
        public bool? Crdawardpoints { get; set; }
        public string Contact { get; set; }
        public string Companyfax { get; set; }
        public string Email { get; set; }
        public string Currencycode { get; set; }
        public string Curdescription { get; set; }
        public string Cursymbol { get; set; }
        public int? Paytermcode { get; set; }
        public string Ptdescription { get; set; }
        public int? Ptnumdays { get; set; }
        public int? PtdiscountedDays { get; set; }
        public double? Ptdiscount { get; set; }
        public double? PtinterestRate { get; set; }
        public int? PtchargableAfter { get; set; }
        public bool? EnforceTerms { get; set; }
        public string Pin { get; set; }
        public string Vat { get; set; }
        public string CscatgCode { get; set; }
        public string CscatgName { get; set; }
        public string CscatgGl { get; set; }
        public int? Routecode { get; set; }
        public bool? Forcemember { get; set; }
        public bool? Defcashinvoice { get; set; }
        public bool? Nonregistered { get; set; }
        public bool? Defcustominvoice { get; set; }
        public double? Creditlimit { get; set; }
        public double? TempCreditlimit { get; set; }
        public bool? Selme { get; set; }
        public string Invuser { get; set; }
        public int? Bcode { get; set; }
        public bool? Blocked { get; set; }
    }
}
