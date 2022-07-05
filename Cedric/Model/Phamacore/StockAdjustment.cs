﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class StockAdjustment
    {
        public int InvJDetnum { get; set; }
        public DateTime? InvJDate { get; set; }
        public string InvCode { get; set; }
        public string InvJRef { get; set; }
        public string InvJDesc { get; set; }
        public double? InvJQty { get; set; }
        public string InvJIo { get; set; }
        public double? InvJCost { get; set; }
        public string InvJName { get; set; }
        public bool Batched { get; set; }
        public double? InvJTvalue { get; set; }
        public string InvJContra { get; set; }
        public string InvJOrderref { get; set; }
        public DateTime? DatePosted { get; set; }
        public double? Oldcost { get; set; }
        public int? StkNum { get; set; }
        public string Partwhole { get; set; }
        public double? Packqty { get; set; }
        public double? Pwqty { get; set; }
        public int Bcode { get; set; }
        public string Username { get; set; }
        public int? Stkref { get; set; }
        public int Nxtstkadj { get; set; }
    }
}
