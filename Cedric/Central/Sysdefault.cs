using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Sysdefault
    {
        public string Company { get; set; }
        public string Address { get; set; }
        public string PhysicalAddress { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Pinno { get; set; }
        public string Vatno { get; set; }
        public string CurrentPeriod { get; set; }
        public DateTime? CurrentStartdate { get; set; }
        public DateTime? CurrentEnddate { get; set; }
        public bool? Autosbgcode { get; set; }
        public bool? Autostockcode { get; set; }
        public string Invhyphen { get; set; }
        public int? Itemcodestyle { get; set; }
        public string Xchdb { get; set; }
        public string Maindb { get; set; }
        public int? Bcode { get; set; }
        public string Clouddb { get; set; }
        public string Cloudip { get; set; }
    }
}
