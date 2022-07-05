using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Branch
    {
        public int Bcode { get; set; }
        public string Branchcode { get; set; }
        public string BranchName { get; set; }
        public bool? Enabled { get; set; }
        public bool? Mainbranch { get; set; }
        public bool? Acct { get; set; }
        public bool? Showallcustomer { get; set; }
        public bool? Showallcustomertrans { get; set; }
    }
}
