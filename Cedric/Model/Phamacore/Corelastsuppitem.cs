using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Corelastsuppitem
    {
        public DateTime Transtime { get; set; }
        public string SuppCode { get; set; }
        public string SinvNumber { get; set; }
        public DateTime? SinvDate { get; set; }
        public string SuppDesc { get; set; }
        public string SuppRef { get; set; }
        public int? SinvNum { get; set; }
        public int Pkqty { get; set; }
        public string Partwhole { get; set; }
        public double? Price { get; set; }
        public double Quantity { get; set; }
        public double Bonus { get; set; }
        public double Discount { get; set; }
        public string InvCode { get; set; }
    }
}
