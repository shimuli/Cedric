using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class MnfHd
    {
        public int MnfNum { get; set; }
        public int Bcode { get; set; }
        public int BmtNum { get; set; }
        public DateTime MnfDate { get; set; }
        public string MnfinvCode { get; set; }
        public string MnfinvName { get; set; }
        public string Mnfunit { get; set; }
        public double? Mnfquantity { get; set; }
        public string Mnfpartwhole { get; set; }
        public double? Mnfpackqty { get; set; }
        public double? Mnfpwqty { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? Mnfmanfdate { get; set; }
        public DateTime? Mnfexpdate { get; set; }
        public string Mnfbatchnum { get; set; }
        public string Mnfbatchsize { get; set; }
        public string Mnfpacksize { get; set; }
        public string LocCode { get; set; }
        public double TradeDiscount { get; set; }
        public double MnfVat { get; set; }
        public double MnfTotal { get; set; }
        public double MnfNet { get; set; }
        public double MnfD { get; set; }
        public string MnfNumber { get; set; }
        public string SupRef { get; set; }
        public string Comments { get; set; }
        public bool Pending { get; set; }
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
        public int? Printcopy { get; set; }
        public int? MnfstkNum { get; set; }
        public bool? Bmtlinked { get; set; }
        public int? Bmrdet { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
