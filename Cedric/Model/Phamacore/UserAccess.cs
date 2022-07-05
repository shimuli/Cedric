using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class UserAccess
    {
        public string Username { get; set; }
        public int? ModuleCode { get; set; }
        public bool Status { get; set; }
    }
}
