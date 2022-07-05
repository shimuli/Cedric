﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class VwCreditNote
    {
        public string SaleinvNumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string InvStrength { get; set; }
        public string InvCode { get; set; }
        public double Returned { get; set; }
        public double? Taken { get; set; }
        public double? Balance { get; set; }
        public int SaleinvDetNum { get; set; }
        public string Partwhole { get; set; }
        public int? Bcode { get; set; }
    }
}
