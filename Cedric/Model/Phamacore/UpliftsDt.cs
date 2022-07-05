using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class UpliftsDt
    {
        public int Id { get; set; }
        public string UpliftCode { get; set; }
        public string Pricename { get; set; }
        public string Valuename { get; set; }
        public double Factor { get; set; }
        public double Constant { get; set; }
        public int? Priceorder { get; set; }
    }
}
