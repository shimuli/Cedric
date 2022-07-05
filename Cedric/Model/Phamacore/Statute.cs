using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Statute
    {
        public int Payyear { get; set; }
        public double? Nssfrate { get; set; }
        public double? Taxrelief { get; set; }
        public double? Insurerelief { get; set; }
        public int? Otmode { get; set; }
        public double? Daysperweek { get; set; }
        public double? Hoursperday { get; set; }
        public int? Maxloanperiod { get; set; }
        public int? Maxadvanceperiod { get; set; }
        public int? Maxloans { get; set; }
        public double? Loanintco { get; set; }
        public double? Loanintlow { get; set; }
        public double? Loanintgov { get; set; }
    }
}
