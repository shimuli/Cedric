using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Import
    {
        public int? OrdNum { get; set; }
        public string OrdNumber { get; set; }
        public DateTime? OrdDate { get; set; }
        public double? OrdPrice { get; set; }
        public string Currencycode { get; set; }
        public double? OrdExchrate { get; set; }
        public double? OrdKshs { get; set; }
        public string ProfomaNum { get; set; }
        public DateTime? ProfomaDate { get; set; }
        public DateTime? IdfAppdate { get; set; }
        public DateTime? IdfTomoh { get; set; }
        public DateTime? IdfFrommoh { get; set; }
        public DateTime? IdfToinspagent { get; set; }
        public DateTime? IdfFrominspagent { get; set; }
        public string IdfNum { get; set; }
        public DateTime? IdfTosupp { get; set; }
        public DateTime? IdfSupprcpt { get; set; }
        public DateTime? TentshipDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? AdviceDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? ShipdocsDate { get; set; }
        public DateTime? CrfRcvddate { get; set; }
        public DateTime? ClrDocstoagent { get; set; }
        public DateTime? ClrFromagent { get; set; }
        public string Ref { get; set; }
        public DateTime? ClrDate { get; set; }
        public DateTime? RcvdDate { get; set; }
        public DateTime? PaydueDate { get; set; }
        public string SuppCode { get; set; }
        public DateTime? PaymadeDate { get; set; }
        public double? PayExchrate { get; set; }
        public double? PayKshs { get; set; }
        public bool Reconciled { get; set; }
    }
}
