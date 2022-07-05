using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Ctstkdeadmake
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public double? Itempack { get; set; }
        public string Manufcode { get; set; }
        public string Manufname { get; set; }
        public string Subgcode { get; set; }
        public string Subgname { get; set; }
        public double? Itemcost { get; set; }
        public double? Itemcostcalc { get; set; }
        public double? Itemavgcost { get; set; }
        public double? Itemavgcostcalc { get; set; }
        public double? Itemlastcost { get; set; }
        public double? Itemlastcostcalc { get; set; }
        public double? Instockqty { get; set; }
        public string Instockqtypw { get; set; }
        public int Bcode { get; set; }
        public string Branchname { get; set; }
        public DateTime? Lastsaledate { get; set; }
        public int? Lastsaledays { get; set; }
        public int? Lastsalecode { get; set; }
        public string Lastsalename { get; set; }
        public DateTime? Lastpurchdate { get; set; }
        public int? Lastpurchdays { get; set; }
        public int? Lastpurchcode { get; set; }
        public string Lastpurchname { get; set; }
        public int Entryid { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Makeuser { get; set; }
        public string Entrystatus { get; set; }
    }
}
