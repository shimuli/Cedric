using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Drugentry
    {
        public int Drugt { get; set; }
        public int Drugtentryno { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double? Packqty { get; set; }
        public double Quantity { get; set; }
        public string Partwhole { get; set; }
        public string TaxCode { get; set; }
        public double Totalcost { get; set; }
        public double TaxAmt { get; set; }
        public double? Pwqty { get; set; }
        public string EmpNum { get; set; }
        public int? SaleinvNum { get; set; }
        public int? CsaleNum { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public int? W1 { get; set; }
        public int? W2 { get; set; }
        public int? Visitentrynum { get; set; }
        public int? Cdocnum { get; set; }
        public int? Bill { get; set; }
        public double? Xpaid { get; set; }
        public int? Cashallow { get; set; }
        public bool? Returned { get; set; }
        public string Returncomment { get; set; }
        public DateTime? Drugdate { get; set; }
        public int? Doctype { get; set; }
        public bool? Docstop { get; set; }
        public string Docdosage { get; set; }
        public bool? Testcomplete { get; set; }
        public bool? Phamadisp { get; set; }
    }
}
