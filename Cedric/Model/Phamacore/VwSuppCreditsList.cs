using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwSuppCreditsList
    {
        public string SuppCode { get; set; }
        public int? DocNum { get; set; }
        public DateTime? SinvDate { get; set; }
        public string TransDesc { get; set; }
        public double? Amount { get; set; }
        public string DocReference { get; set; }
    }
}
