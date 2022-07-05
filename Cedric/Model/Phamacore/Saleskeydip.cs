using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Saleskeydip
    {
        public DateTime? TransDate { get; set; }
        public string InvCode { get; set; }
        public string InvName { get; set; }
        public string InvPhysical { get; set; }
        public string InvManuf { get; set; }
        public string InvGroup { get; set; }
        public string InvSubgroup { get; set; }
        public string InvStockclassif { get; set; }
        public string InvStockmainclass { get; set; }
        public string InvStockform { get; set; }
        public string CusCode { get; set; }
        public string CusName { get; set; }
        public string CusSalesmen { get; set; }
        public string CusRoute { get; set; }
        public string CusPayterms { get; set; }
        public string CusCuscategory { get; set; }
        public string CusCreditcategory { get; set; }
        public string CusPostcategory { get; set; }
        public string CusTown { get; set; }
        public double? SaleQty { get; set; }
        public double? SaleValue { get; set; }
        public double? CostAvgcostvalue { get; set; }
        public double? CostLastcostvalue { get; set; }
        public string Printuser { get; set; }
        public double? InvPackqty { get; set; }
        public double? SalePwqty { get; set; }
        public string SalePw { get; set; }
        public string Datecrit { get; set; }
        public string Othercrit { get; set; }
    }
}
