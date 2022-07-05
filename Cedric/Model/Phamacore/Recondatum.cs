using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Recondatum
    {
        public int DocNumber { get; set; }
        public DateTime? TransDate { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public bool? Reconcile { get; set; }
        public string ReconPeriod { get; set; }
        public string TransType { get; set; }
        public int Bcode { get; set; }
        public double Dorder { get; set; }
        public double Corder { get; set; }
        public string Reconuser { get; set; }
    }
}
