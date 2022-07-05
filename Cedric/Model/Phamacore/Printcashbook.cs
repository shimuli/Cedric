using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printcashbook
    {
        public string BankAcct { get; set; }
        public string BankName { get; set; }
        public string Gcs { get; set; }
        public DateTime? DocDate { get; set; }
        public string AccCode { get; set; }
        public string AccName { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public double Amountpaid { get; set; }
        public string Paymode { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Amountinwords { get; set; }
        public string Comments { get; set; }
        public string DocUserName { get; set; }
        public string PrintUserName { get; set; }
        public int? Docdetnum { get; set; }
        public string Docname { get; set; }
        public int? Bcode { get; set; }
        public string Branchname { get; set; }
    }
}
