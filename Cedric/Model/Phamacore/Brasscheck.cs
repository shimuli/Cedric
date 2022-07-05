using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Brasscheck
    {
        public string InvCode { get; set; }
        public int Bcode { get; set; }
        public string Username { get; set; }
        public double? Docqty { get; set; }
        public double? Stkqty { get; set; }
        public string Docqtypw { get; set; }
        public double? Salesqty { get; set; }
        public string Salesqtypw { get; set; }
        public double? Purchqty { get; set; }
        public string Purchqtypw { get; set; }
        public double? Transfqty { get; set; }
        public string Transfqtypw { get; set; }
        public double? Adjqty { get; set; }
        public string Adjqtypw { get; set; }
        public double? Docqtyopen { get; set; }
        public string Docqtyopenpw { get; set; }
    }
}
