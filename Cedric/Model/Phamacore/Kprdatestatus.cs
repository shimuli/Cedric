﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Kprdatestatus
    {
        public string Thisprdmonth { get; set; }
        public string Thisprd { get; set; }
        public int Thisprdnum { get; set; }
        public int Thisyear { get; set; }
        public bool? Posted { get; set; }
    }
}
