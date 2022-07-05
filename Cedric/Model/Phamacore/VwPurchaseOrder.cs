using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwPurchaseOrder
    {
        public string PorderNumber { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvStrength { get; set; }
        public double? Quantity { get; set; }
        public double Metquantity { get; set; }
        public double? Remquantity { get; set; }
        public int PorderDetNum { get; set; }
        public string Partwhole { get; set; }
    }
}
