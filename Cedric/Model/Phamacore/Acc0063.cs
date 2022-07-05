using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Acc0063
    {
        public int Id { get; set; }
        public int Documentid { get; set; }
        public string Salespersonid { get; set; }
        public int? Documentstatusid { get; set; }
        public string Documentno { get; set; }
        public string Refno { get; set; }
        public string Sourcedocumentno { get; set; }
        public DateTime? Transactiondate { get; set; }
        public DateTime? Sysdate { get; set; }
        public string Userid { get; set; }
        public DateTime? Duedate { get; set; }
        public string Memo { get; set; }
        public string Customermessage { get; set; }
        public string Billto { get; set; }
        public string Shipto { get; set; }
        public string WhsCdFrom { get; set; }
        public string WhsCdTo { get; set; }
        public string Transfertypeid { get; set; }
        public bool? Integrated { get; set; }
        public DateTime? Documentdate { get; set; }
    }
}
