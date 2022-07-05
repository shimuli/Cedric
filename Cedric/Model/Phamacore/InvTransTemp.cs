using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class InvTransTemp
    {
        public int ModuleCode { get; set; }
        public int TransNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string LocCode { get; set; }
        public string BatchNum { get; set; }
        public DateTime? TransDate { get; set; }
        public string InvCode { get; set; }
        public int QtyIn { get; set; }
        public int QtyOut { get; set; }
        public int Entryno { get; set; }
        public bool Posted { get; set; }
        public bool Increase { get; set; }
        public int QtyTomove { get; set; }
        public bool Selected { get; set; }
    }
}
