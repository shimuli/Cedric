﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Cttransact
    {
        public string Tabname { get; set; }
        public string Fldnames { get; set; }
        public string Flduniq { get; set; }
        public bool? Dowork { get; set; }
        public bool? Impqry { get; set; }
        public int? Coreserviceno { get; set; }
    }
}
