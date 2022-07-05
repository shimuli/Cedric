using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Pricechangesupp
    {
        public int SinvNum { get; set; }
        public int SinvDetNum { get; set; }
        public int Bcode { get; set; }
        public string SinvNumber { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public double? Itemprice { get; set; }
        public double? Itempricelpo { get; set; }
        public double? Itempricelpodiff { get; set; }
        public double? Itempricelastcost { get; set; }
        public double? Itempricelastcostdiff { get; set; }
        public double? Itempricelastsupp { get; set; }
        public double? Itempricelastsuppdiff { get; set; }
        public double? Itempricetradeprice { get; set; }
        public double? Itempricetradepricediff { get; set; }
        public DateTime? Processdate { get; set; }
    }
}
