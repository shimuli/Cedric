using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class TillrepsHd
    {
        public string BankAcct { get; set; }
        public int? Tillno { get; set; }
        public int? Tillsessno { get; set; }
        public string UserName { get; set; }
        public DateTime? TrpDate { get; set; }
        public string Gcs { get; set; }
        public string Gcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string Referenceother { get; set; }
        public double Amountpaid { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public double? XrateNet { get; set; }
        public string Paymode { get; set; }
        public DateTime? ChqDate { get; set; }
        public string Comments { get; set; }
        public int TrpDetnum { get; set; }
        public DateTime? Entrydate { get; set; }
        public bool Batched { get; set; }
    }
}
