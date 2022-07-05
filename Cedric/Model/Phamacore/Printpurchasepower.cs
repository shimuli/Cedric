using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printpurchasepower
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public double? Itempack { get; set; }
        public string Username { get; set; }
        public double? Closeingstockqty { get; set; }
        public double? Openingstockqty { get; set; }
        public int? Bcode { get; set; }
        public double? Lastordqty { get; set; }
        public string Lastordqtypw { get; set; }
        public DateTime? Lastorddate { get; set; }
        public double? Lastordprice { get; set; }
        public double? Lastorddisc { get; set; }
        public double? Totalsalesqty { get; set; }
        public double? Totalsalesvalue { get; set; }
        public string Totalsalesqtypw { get; set; }
        public double? Nowordqty { get; set; }
        public string Nowordqtypw { get; set; }
        public string Closeingstockqtypw { get; set; }
        public string Openingstockqtypw { get; set; }
        public double? Reorderqty { get; set; }
        public double? Tradeprice { get; set; }
        public double? Lastsuppqty { get; set; }
        public string Lastsuppqtypw { get; set; }
        public DateTime? Lastsuppdate { get; set; }
        public double? Lastsuppprice { get; set; }
        public double? Lastsuppdisc { get; set; }
        public double? Minqty { get; set; }
        public double? Getordqty { get; set; }
        public string Getordpw { get; set; }
        public double? Getordbonus { get; set; }
        public bool? Getsel { get; set; }
        public int Pwrentry { get; set; }
        public double? Setordqty { get; set; }
        public string Setordqtypw { get; set; }
        public string Selcrit { get; set; }
        public double? Salesdays { get; set; }
        public double? Orderdays { get; set; }
        public double? Avgsalesqty { get; set; }
        public string Avgsalesqtypw { get; set; }
        public double? Orderdaysqty { get; set; }
        public string Orderdaysqtypw { get; set; }
        public double? Varianceqty { get; set; }
        public string Varianceqtypw { get; set; }
    }
}
