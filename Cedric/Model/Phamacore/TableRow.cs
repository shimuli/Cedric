using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class TableRow
    {
        public int Id { get; set; }
        public int? ReceiptsHeader { get; set; }
        public int? PaymentHeader { get; set; }
    }
}
