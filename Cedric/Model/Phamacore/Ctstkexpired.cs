using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Ctstkexpired
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
        public double Instockqty { get; set; }
        public string Instockqtypw { get; set; }
        public int Bcode { get; set; }
        public string Branchname { get; set; }
        public string Loccode { get; set; }
        public string Locname { get; set; }
        public double Expstockqty { get; set; }
        public string Batchnumber { get; set; }
        public DateTime? Expdate { get; set; }
        public int? Expdays { get; set; }
        public int? Expcode { get; set; }
        public string Expname { get; set; }
        public int Entryid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
