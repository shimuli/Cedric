using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Loanshd
    {
        public int Transno { get; set; }
        public int Transtype { get; set; }
        public string EdCode { get; set; }
        public string EmpNum { get; set; }
        public DateTime? TransDate { get; set; }
        public double? Transamount { get; set; }
        public string BankAcct { get; set; }
        public string Paymode { get; set; }
        public string Reference { get; set; }
        public DateTime ChqDate { get; set; }
        public string Paidby { get; set; }
        public double? Intrate { get; set; }
        public double? Transnett { get; set; }
        public double? Installment { get; set; }
        public double? Instamount { get; set; }
        public bool? Usebalance { get; set; }
        public bool? Currentperiod { get; set; }
        public int? PayDetnum { get; set; }
        public string Startprd { get; set; }
        public int? Startprdnum { get; set; }
        public int? Startpayyear { get; set; }
        public string Endprd { get; set; }
        public int? Endprdnum { get; set; }
        public int? Endpayyear { get; set; }
        public string Prd { get; set; }
        public int? Prdnum { get; set; }
        public int? Payyear { get; set; }
        public double? Transpaid { get; set; }
        public double? Transbalance { get; set; }
        public double? Transarrears { get; set; }
        public bool? Active { get; set; }
        public bool? Posted { get; set; }
        public bool? Cleared { get; set; }
        public string Username { get; set; }
    }
}
