using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Expinvdesc
    {
        public string InvSubgroupcode { get; set; }
        public string Sbgname { get; set; }
        public bool? Sbggl { get; set; }
        public bool? Sbgisacct { get; set; }
        public string Gpcode { get; set; }
        public string Gpname { get; set; }
        public string SalesGl { get; set; }
        public string CostofsalesGl { get; set; }
        public string InvadjustmentGl { get; set; }
        public string InventoryGl { get; set; }
        public bool? Gpisacct { get; set; }
        public string InvCode { get; set; }
        public string Description { get; set; }
        public string InvItemcontents { get; set; }
        public string InvStrength { get; set; }
        public string PackageCode { get; set; }
        public string Pkgname { get; set; }
        public string ManufacturerCode { get; set; }
        public string Mnfname { get; set; }
        public string Mnfcountry { get; set; }
        public string Mnfintial { get; set; }
        public string InvUnit { get; set; }
        public int PackQty { get; set; }
        public int? UnitQty { get; set; }
        public string InvNotes { get; set; }
        public string ActiveIngredient { get; set; }
        public string Barcode { get; set; }
        public bool? Blocked { get; set; }
        public bool? InvPhysicalitem { get; set; }
        public bool? InvBrandgeneric { get; set; }
        public bool Noexpiry { get; set; }
        public bool? Rawmaterial { get; set; }
        public bool? Selme { get; set; }
        public string Invuser { get; set; }
        public bool? Kisimax { get; set; }
        public bool? Forpackalter { get; set; }
        public string PackinvCode { get; set; }
        public string PackinvName { get; set; }
        public bool? Forpackalterused { get; set; }
    }
}
