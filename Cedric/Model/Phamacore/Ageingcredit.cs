using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Ageingcredit
    {
        public string CusCode { get; set; }
        public DateTime? Transdate { get; set; }
        public double Balance { get; set; }
        public string TransType { get; set; }
        public int PayNo { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public int? NumDays { get; set; }
        public double Uptothirty { get; set; }
        public double Thirtydays { get; set; }
        public double Sixtydays { get; set; }
        public double Ninety { get; set; }
        public double OneTwenty { get; set; }
    }
}
