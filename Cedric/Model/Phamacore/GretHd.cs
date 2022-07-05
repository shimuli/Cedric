using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class GretHd
    {
        public int GretNum { get; set; }
        public int Bcode { get; set; }
        public string SuppCode { get; set; }
        public DateTime? GretDate { get; set; }
        public DateTime? PayDue { get; set; }
        public int? SinvNum { get; set; }
        public double TradeDiscount { get; set; }
        public double GretVat { get; set; }
        public double GretD { get; set; }
        public double GretNet { get; set; }
        public short? ContNum { get; set; }
        public double GretTotal { get; set; }
        public bool Batched { get; set; }
        public string GretNumber { get; set; }
        public string SinvNumber { get; set; }
        public string Comments { get; set; }
        public string SuppRef { get; set; }
        public string SuppRefG { get; set; }
        public int? ModuleCode { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public double? Balance { get; set; }
        public bool Existingitems { get; set; }
        public bool Fromgrn { get; set; }
        public string AnalysisCode { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public int? Lastlineno { get; set; }
        public int? Printcopy { get; set; }
        public bool? Bposted { get; set; }
        public double? GretExcise { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
        public int? Whvat { get; set; }
        public string Whvatcode { get; set; }
        public double? Whvatperc { get; set; }
        public double? Whvatamt { get; set; }
        public bool? Suppcleared { get; set; }
        public DateTime? Suppclearingdate { get; set; }
    }
}
