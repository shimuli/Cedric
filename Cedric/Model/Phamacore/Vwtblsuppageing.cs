using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Vwtblsuppageing
    {
        public int SourceDocNum { get; set; }
        public string SourceDocType { get; set; }
        public double? SumOfAmount { get; set; }
        public string CusCode { get; set; }
        public string Username { get; set; }
    }
}
