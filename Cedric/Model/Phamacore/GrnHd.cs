using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class GrnHd
    {
        public int GrnNum { get; set; }
        public int Bcode { get; set; }
        public string SuppCode { get; set; }
        public DateTime? GrnDate { get; set; }
        public DateTime? PayDue { get; set; }
        public string POrderNumber { get; set; }
        public short? ContNum { get; set; }
        public string GrnNumber { get; set; }
        public string Comments { get; set; }
        public bool Batched { get; set; }
        public string SuppRef { get; set; }
        public bool Usedup { get; set; }
        public short? FromSupplierInvoice { get; set; }
        public double? GrnTotal { get; set; }
        public double? TradeDiscount { get; set; }
        public double? GrnVat { get; set; }
        public double? GrnD { get; set; }
        public double? GrnNet { get; set; }
        public double? Amounttopay { get; set; }
        public double? Paid { get; set; }
        public double? Balance { get; set; }
        public double? Paying { get; set; }
        public double? ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public string Idfno { get; set; }
        public int? Lastlineno { get; set; }
        public int? Printcopy { get; set; }
        public bool? Bposted { get; set; }
        public DateTime? Savetime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
