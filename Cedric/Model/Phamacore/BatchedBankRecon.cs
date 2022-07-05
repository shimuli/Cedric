using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BatchedBankRecon
    {
        public string BankAcct { get; set; }
        public DateTime? BatchDate { get; set; }
    }
}
