using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwUnbatchedInvoice
    {
        public string SaleinvNumber { get; set; }
        public DateTime SaleinvDate { get; set; }
        public double? SaleinvNet { get; set; }
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public int SaleinvNum { get; set; }
        public string CusRef { get; set; }
    }
}
