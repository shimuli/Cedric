using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ImpCustDiscount
    {
        public string CusCode { get; set; }
        public short? DiscountCode { get; set; }
        public int? Worthqty { get; set; }
        public int? Bonusdiscount { get; set; }
        public DateTime? Expirydate { get; set; }
        public int Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
        public int Bcode { get; set; }
    }
}
