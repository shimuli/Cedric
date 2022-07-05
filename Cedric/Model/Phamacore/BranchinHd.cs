using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class BranchinHd
    {
        public int BrinNum { get; set; }
        public DateTime BrinDate { get; set; }
        public string SuppCode { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double TradeDiscount { get; set; }
        public double BrinVat { get; set; }
        public double BrinTotal { get; set; }
        public double BrinNet { get; set; }
        public int ContNum { get; set; }
        public double BrinD { get; set; }
        public string BrinNumber { get; set; }
        public string SupRef { get; set; }
        public string Comments { get; set; }
        public bool Pending { get; set; }
        public string GrnNumber { get; set; }
        public string SinvNumber { get; set; }
        public bool Done { get; set; }
        public int Invtype { get; set; }
        public bool Batched { get; set; }
        public int Grntype { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public string PayTerms { get; set; }
        public bool Cancelled { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public string ContName { get; set; }
        public int? Lastlineno { get; set; }
        public string Branchcode { get; set; }
        public string Branchfrom { get; set; }
        public int Bcode { get; set; }
        public int? Bcodefrom { get; set; }
        public int? Kahapi { get; set; }
    }
}
