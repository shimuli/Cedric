using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwShowCurrentSupplier
    {
        public string SuppCode { get; set; }
        public string SuppDesc { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Physicaladd { get; set; }
        public string Town { get; set; }
        public bool? Blocked { get; set; }
        public double? Creditlimit { get; set; }
        public DateTime? Lastpaydate { get; set; }
        public double? Lastpayamount { get; set; }
        public double? Balance { get; set; }
        public int? TownCode { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public double? Unapplied { get; set; }
        public double? Used { get; set; }
        public double? Using { get; set; }
        public double? UnappliedBalance { get; set; }
        public double? TotalPurchases { get; set; }
        public double? StatementCurrentbal { get; set; }
        public double? Overapplied { get; set; }
        public double? Used2 { get; set; }
        public double? Using2 { get; set; }
        public double? OverAppliedBalance { get; set; }
        public int Counter { get; set; }
        public string Currencycode { get; set; }
        public string Terms { get; set; }
        public bool? Printstatement { get; set; }
        public string Pinno { get; set; }
        public string Vatno { get; set; }
        public string SpcatgCode { get; set; }
        public bool? Xblocked { get; set; }
        public double? Openingbal { get; set; }
        public string Description { get; set; }
        public bool Default { get; set; }
        public string Contact { get; set; }
        public int? ContNum { get; set; }
    }
}
