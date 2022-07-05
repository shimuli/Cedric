using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Stocktakeneo
    {
        public int Userdataid { get; set; }
        public int? Bcode { get; set; }
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public int? PkSz { get; set; }
        public double? InStkUnits { get; set; }
        public string InStkPw { get; set; }
        public string InvSubgroupcode { get; set; }
        public bool? Fastmoving { get; set; }
        public bool? Highvalue { get; set; }
        public string PackageCode { get; set; }
        public string Branchname { get; set; }
    }
}
