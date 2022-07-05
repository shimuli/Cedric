using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwlpotransferpart
    {
        public string PorderinNumber { get; set; }
        public string Description { get; set; }
        public double Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public double Returned { get; set; }
        public double? Taken { get; set; }
        public double? Balance { get; set; }
        public int PorderinDetNum { get; set; }
        public int? SoDetNum { get; set; }
        public string Partwhole { get; set; }
        public int? Sbcode { get; set; }
        public int Bcode { get; set; }
        public int PorderinNum { get; set; }
        public string Partreturned { get; set; }
        public int Parttaken { get; set; }
        public string Partbalance { get; set; }
        public double Price { get; set; }
        public double LineDisc { get; set; }
        public string TaxCode { get; set; }
        public double? Partbakshishi { get; set; }
        public string CusCode { get; set; }
    }
}
