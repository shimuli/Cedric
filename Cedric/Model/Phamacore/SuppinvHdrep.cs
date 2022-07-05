﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SuppinvHdrep
    {
        public int? SinvNum { get; set; }
        public string SuppCode { get; set; }
        public DateTime? SinvDate { get; set; }
        public DateTime? PayDue { get; set; }
        public string OrderNum { get; set; }
        public double? TradeDiscount { get; set; }
        public double? SinvVat { get; set; }
        public double? SinvD { get; set; }
        public double? SinvNet { get; set; }
        public short? ContNum { get; set; }
        public double? SinvTotal { get; set; }
        public int? GrnNum { get; set; }
        public string SinvNumber { get; set; }
        public bool Batched { get; set; }
        public double? Amounttopay { get; set; }
        public double? Paid { get; set; }
        public double? Balance { get; set; }
        public double? Paying { get; set; }
        public string Comments { get; set; }
        public bool Done { get; set; }
        public string SuppRef { get; set; }
        public string GrnNumber { get; set; }
        public short? Invoicetype { get; set; }
        public string SuppInvoicenum { get; set; }
        public bool Sdone { get; set; }
        public bool Pending { get; set; }
        public double? ExchRate { get; set; }
        public string Currencycode { get; set; }
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public string Idfno { get; set; }
        public bool Cashpurchase { get; set; }
        public string AnalysisCode { get; set; }
        public DateTime? Awbdate { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public int? Printcopy { get; set; }
        public int? Lastlineno { get; set; }
        public int Myprintcopy { get; set; }
        public int? Bcode { get; set; }
        public bool? Bposted { get; set; }
    }
}
