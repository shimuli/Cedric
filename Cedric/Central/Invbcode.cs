using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Invbcode
    {
        public string InvCode { get; set; }
        public int Bcode { get; set; }
        public string Calcpw { get; set; }
        public double? Calcqty { get; set; }
        public double? Valqty { get; set; }
        public int? PackQty { get; set; }
        public double? Reqty { get; set; }
        public string InvSubgroupcode { get; set; }
        public string Description { get; set; }
        public string ManufacturerCode { get; set; }
        public double? InvRetailprice { get; set; }
        public double? InvTradeprice { get; set; }
        public double? InvSpecialprice { get; set; }
        public double? InvMinprice { get; set; }
        public double? InvLastunitcost { get; set; }
        public double? InvCostprice { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public string TaxCode { get; set; }
        public bool? Blocked { get; set; }
        public string InvStrength { get; set; }
        public string ActiveIngredient { get; set; }
        public double? Stkrolevel { get; set; }
        public double? Stkroqty { get; set; }
        public double? InvAvgcost { get; set; }
        public double? Calcqtyopen { get; set; }
        public string CalcqtyopenPw { get; set; }
        public bool? InvBrandgeneric { get; set; }
        public double? InvWsaleprice { get; set; }
        public string InvUnit { get; set; }
        public double? InvAvgsellcost { get; set; }
        public string Branchname { get; set; }
        public int Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
        public int? Invbcodedetref { get; set; }
        public DateTime? Lastupdate { get; set; }
    }
}
