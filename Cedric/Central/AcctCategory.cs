using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class AcctCategory
    {
        public int Acctcatgcode { get; set; }
        public string Acctcatgname { get; set; }
        public int? Startacct { get; set; }
        public int? Endacct { get; set; }
        public int? Bcode { get; set; }
    }
}
