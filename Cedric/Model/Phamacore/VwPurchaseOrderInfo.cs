using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwPurchaseOrderInfo
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Strength { get; set; }
        public string Unit { get; set; }
        public int OrderQty { get; set; }
        public double LastPrice { get; set; }
        public string Manuf { get; set; }
        public double? InStock { get; set; }
        public double? OnOrder { get; set; }
        public int LastOrdered { get; set; }
        public string SuppCode { get; set; }
        public string SuppDesc { get; set; }
        public string InvCode { get; set; }
        public double? Jan { get; set; }
        public double? Feb { get; set; }
        public double? Mar { get; set; }
        public double? Apr { get; set; }
        public double? May { get; set; }
        public double? Jun { get; set; }
        public double? Jul { get; set; }
        public double? Aug { get; set; }
        public double? Sep { get; set; }
        public double? Oct { get; set; }
        public double? Nov { get; set; }
        public double? Dec { get; set; }
        public double? Total { get; set; }
    }
}
