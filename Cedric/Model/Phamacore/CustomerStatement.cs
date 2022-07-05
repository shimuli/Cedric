using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CustomerStatement
    {
        public int Id1 { get; set; }
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransType { get; set; }
        public string Description { get; set; }
        public string Ref { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? Cusbalance { get; set; }
        public double? Thirtydays { get; set; }
        public double? Sixtydays { get; set; }
        public double? Ninetydays { get; set; }
        public double? Uptothirty { get; set; }
        public double? Onetwenty { get; set; }
        public double? Unallocated { get; set; }
        public double? StatementCurrentbal { get; set; }
        public double? Balance { get; set; }
        public double? CurrentBalance { get; set; }
        public double? UnappliedBalance { get; set; }
        public double? Creditlimit { get; set; }
        public DateTime? Lastrptdate { get; set; }
        public double? TotalSales { get; set; }
        public double? Id { get; set; }
        public bool? Blocked { get; set; }
        public string Status { get; set; }
        public string ProvinceCode { get; set; }
        public string SalesCode { get; set; }
        public string Cstype { get; set; }
        public double? Showdebit { get; set; }
        public double? Showcredit { get; set; }
        public double? Showbalance { get; set; }
        public double? Showunallocated { get; set; }
        public string Postcode { get; set; }
        public string Username { get; set; }
        public double? Docbal { get; set; }
        public double? ExchRate { get; set; }
        public int? Display { get; set; }
        public int? Credccode { get; set; }
        public string Credcname { get; set; }
    }
}
