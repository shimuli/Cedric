using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Sysmodule
    {
        public int ModuleCode { get; set; }
        public string Modul { get; set; }
        public string Area { get; set; }
        public bool Loadable { get; set; }
    }
}
