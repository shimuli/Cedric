using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Currency
    {
        public string Currencycode { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public bool? Default { get; set; }
    }
}
