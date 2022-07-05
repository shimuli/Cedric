using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class UpliftsHd
    {
        public string UpliftCode { get; set; }
        public string Description { get; set; }
        public bool? Priceauto { get; set; }
        public int? Pscheme { get; set; }
        public int? Priceautotype { get; set; }
        public string Ptypecode { get; set; }
        public string Ptypename { get; set; }
    }
}
