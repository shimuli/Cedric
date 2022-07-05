using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Dependant
    {
        public string CusCode { get; set; }
        public string Memberno { get; set; }
        public int DependNo { get; set; }
        public string DependName { get; set; }
        public string DependRef { get; set; }
        public DateTime? DependDob { get; set; }
        public string DependSex { get; set; }
        public string DependAddr { get; set; }
        public string DependPhone { get; set; }
    }
}
