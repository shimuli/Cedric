using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class CaseSpecification
    {
        public string UnitNo { get; set; }
        public string SuppCode { get; set; }
        public string Supplier { get; set; }
        public string OrderNo { get; set; }
        public string Description { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public double? Height { get; set; }
        public double? Volume { get; set; }
        public double? GrossWt { get; set; }
        public double? NetWt { get; set; }
        public string Notes { get; set; }
        public string ShipmentNo { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string IdforderNo { get; set; }
    }
}
