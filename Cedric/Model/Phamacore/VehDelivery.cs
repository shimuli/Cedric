using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VehDelivery
    {
        public int VehMakeid { get; set; }
        public int VehCode { get; set; }
        public int VehDeliveryid { get; set; }
        public string VehRegno { get; set; }
        public string VehComments { get; set; }
    }
}
