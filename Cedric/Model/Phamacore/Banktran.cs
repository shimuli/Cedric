using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Banktran
    {
        public string BankAcct { get; set; }
        public DateTime? RctDate { get; set; }
        public string CusCode { get; set; }
        public string RctName { get; set; }
        public string Ref { get; set; }
        public string Descrip { get; set; }
        public double? Amt { get; set; }
        public double? Credit { get; set; }
        public string PayType { get; set; }
        public string BankName { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string DocNum { get; set; }
        public string EntryCleared { get; set; }
        public string DocType { get; set; }
        public string Comments { get; set; }
        public string Username { get; set; }
        public int? Pos { get; set; }
    }
}
