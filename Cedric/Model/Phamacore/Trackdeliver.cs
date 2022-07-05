using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Trackdeliver
    {
        public DateTime? Deliverdate { get; set; }
        public DateTime? Delivertime { get; set; }
        public int Delivernum { get; set; }
        public string Delivercontrol { get; set; }
        public int? SaleinvNum { get; set; }
        public double? Deliverweight { get; set; }
        public double? Deliverpackages { get; set; }
        public string Deliveredby { get; set; }
        public string Deliverid { get; set; }
        public string Receivedby { get; set; }
        public string Receivedid { get; set; }
        public int? DstatCode { get; set; }
        public int? DelCode { get; set; }
        public string Remarks { get; set; }
        public bool? Batched { get; set; }
        public int? Bcode { get; set; }
        public DateTime? Deliverstarttime { get; set; }
        public DateTime? Deliverstartdate { get; set; }
        public string Deliverturnaround { get; set; }
        public int? VehCode { get; set; }
        public string VehMake { get; set; }
        public string VehReg { get; set; }
        public string VehDriver { get; set; }
        public string VehDriverid { get; set; }
        public bool? Sameascontrol { get; set; }
        public int? Doctype { get; set; }
        public int? VehDeliveryid { get; set; }
        public int? Hrsid { get; set; }
        public int? Hrsiddrv { get; set; }
        public bool? Nodelivery { get; set; }
        public bool? Invoicecopy { get; set; }
        public double? Invamountpaid { get; set; }
        public int? Invpaytype { get; set; }
        public bool? Docrecall { get; set; }
    }
}
