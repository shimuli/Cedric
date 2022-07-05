using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class GlTran
    {
        public string Basis { get; set; }
        public string Ref { get; set; }
        public DateTime? Transdate { get; set; }
        public string Documenttype { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string AccountName { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string Contra { get; set; }
        public string ContraName { get; set; }
    }
}
