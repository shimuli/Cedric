using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Prescriptionslog
    {
        public string AdultChild { get; set; }
        public int? Units { get; set; }
        public short? UnitsName { get; set; }
        public short? Tobetaken { get; set; }
        public int? NoOfTimes { get; set; }
        public int? Period { get; set; }
        public string PeriodName { get; set; }
        public int? Quantity { get; set; }
        public string Label { get; set; }
        public string Measure { get; set; }
        public int? Modcode { get; set; }
        public int? Detailnumber { get; set; }
        public string InvCode { get; set; }
    }
}
