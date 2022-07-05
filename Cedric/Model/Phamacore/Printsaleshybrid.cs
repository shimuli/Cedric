using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printsaleshybrid
    {
        public string ItemCode { get; set; }
        public string Username { get; set; }
        public string ItemName { get; set; }
        public string InStore { get; set; }
        public string SaleQty { get; set; }
        public string ReOrderQty { get; set; }
        public double? OrdQty { get; set; }
        public string Pw { get; set; }
        public double? Bns { get; set; }
        public bool? Sel { get; set; }
        public double? Zpack { get; set; }
        public double? InvReoQty { get; set; }
        public double? Closeingstockqty { get; set; }
        public double? Setordqty { get; set; }
        public double? Varianceqty { get; set; }
        public string Repname { get; set; }
        public string Repfilter { get; set; }
        public string Repsubfilter { get; set; }
    }
}
