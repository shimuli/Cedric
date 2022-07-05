using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SelectedDoc
    {
        public string DocNumber { get; set; }
        public string DocType { get; set; }
        public string CurrentUser { get; set; }
    }
}
