using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwDebitsList
    {
        public string CusCode { get; set; }
        public string DocNum { get; set; }
        public DateTime? SaleinvDate { get; set; }
        public string TransDesc { get; set; }
        public double? Amount { get; set; }
    }
}
