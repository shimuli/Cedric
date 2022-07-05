using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ScreditHd
    {
        public int ScreditNum { get; set; }
        public string SuppCode { get; set; }
        public DateTime? ScreditDate { get; set; }
        public DateTime? PayDue { get; set; }
        public int? SinvNum { get; set; }
        public double? TradeDiscount { get; set; }
        public double? ScreditVat { get; set; }
        public double? ScreditD { get; set; }
        public double? ScreditNet { get; set; }
        public short? ContNum { get; set; }
        public double? ScreditTotal { get; set; }
        public bool Batched { get; set; }
        public string ScreditNumber { get; set; }
        public string SinvNumber { get; set; }
        public string Comments { get; set; }
        public string SuppRef { get; set; }
        public string SuppRefS { get; set; }
        public double? ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public double? Balance { get; set; }
    }
}
