using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Stock
    {
        public string Itmcode { get; set; }
        public string Itmname { get; set; }
        public string Gpcode { get; set; }
        public string Gpname { get; set; }
        public string Sbgpcode { get; set; }
        public string Sbgpname { get; set; }
        public string Pkgcode { get; set; }
        public string Pkgname { get; set; }
        public string Mnfcode { get; set; }
        public string Mnfname { get; set; }
        public double? Stocktradeprice { get; set; }
        public double? Stockretailprice { get; set; }
        public double? Stockwsaleprice { get; set; }
        public double? Stocklastcost { get; set; }
        public double? Stockavgcost { get; set; }
        public int? Formcode { get; set; }
        public string Formname { get; set; }
        public int? Classcode { get; set; }
        public string Classname { get; set; }
        public bool? Phyitem { get; set; }
        public double? Packqty { get; set; }
        public int Crudorder { get; set; }
    }
}
