using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Printtrack
    {
        public DateTime? Trackdate { get; set; }
        public string Tracktime { get; set; }
        public int Tracknum { get; set; }
        public string Trackcontrol { get; set; }
        public int? SaleinvNum { get; set; }
        public double? SaleinvNet { get; set; }
        public string Customername { get; set; }
        public double? Trackweight { get; set; }
        public double? Trackpackages { get; set; }
        public string Trackactionby { get; set; }
        public string Collectid { get; set; }
        public string Collecttype { get; set; }
        public string Collectmode { get; set; }
        public string Remarks { get; set; }
        public int Tracktype { get; set; }
        public string Trackname { get; set; }
        public string Username { get; set; }
        public string Salesman { get; set; }
        public string Invoicenumber { get; set; }
        public double? Invpaid { get; set; }
    }
}
