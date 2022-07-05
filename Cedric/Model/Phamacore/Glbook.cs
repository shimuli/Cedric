using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Glbook
    {
        public DateTime? Gldate { get; set; }
        public string Glref { get; set; }
        public string Gldesc { get; set; }
        public string Doctype { get; set; }
        public string Docacc { get; set; }
        public string Docname { get; set; }
        public string Acct { get; set; }
        public string Acctname { get; set; }
        public double? Gldebit { get; set; }
        public double? Glcredit { get; set; }
        public int Entryno { get; set; }
        public string Username { get; set; }
        public int? Glpos { get; set; }
        public string Custsup { get; set; }
    }
}
