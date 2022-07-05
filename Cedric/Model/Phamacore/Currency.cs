using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Currency
    {
        public string Description { get; set; }
        public string Symbol { get; set; }
        public string Currencycode { get; set; }
        public bool Default { get; set; }
    }
}
