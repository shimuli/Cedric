using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Xpareto
    {
        public string Username { get; set; }
        public string InvCode { get; set; }
        public string Itemdesc { get; set; }
        public double? Avgcost { get; set; }
        public double? Stockbalance { get; set; }
        public string Stockbalancepw { get; set; }
        public double? Packqty { get; set; }
        public double? Salesqty { get; set; }
        public double? Salesvalue { get; set; }
        public double? Salesqtycont { get; set; }
        public double? Salesvaluecont { get; set; }
        public double? Cumsalesqtycont { get; set; }
        public double? Cumsalesvaluecont { get; set; }
        public int? Paretosalesqty { get; set; }
        public int? Paretosalesvalue { get; set; }
        public int? Paretofinal { get; set; }
        public string Paretoname { get; set; }
        public double? Threemsalesqty { get; set; }
        public double? Threemsalesvalue { get; set; }
        public double? Avgsalesqty { get; set; }
        public double? Stockdepth { get; set; }
        public double? Propordqty { get; set; }
        public double? Ordqty { get; set; }
        public double Ordvalue { get; set; }
        public double? Ordqtyonorder { get; set; }
        public double? OrdqtyPw { get; set; }
        public string OrdqtyPartwhole { get; set; }
        public string SalesqtyPw { get; set; }
        public string Manufname { get; set; }
        public string AvgsalesqtyPw { get; set; }
    }
}
