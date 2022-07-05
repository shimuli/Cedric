using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ScJournal
    {
        public int ScJDetnum { get; set; }
        public int Bcode { get; set; }
        public DateTime? ScJDate { get; set; }
        public string CusCode { get; set; }
        public string SuppCode { get; set; }
        public string GCode { get; set; }
        public string ScJRef { get; set; }
        public string ScJDesc { get; set; }
        public double ScJAmount { get; set; }
        public string ScJTax { get; set; }
        public double ScJInclusive { get; set; }
        public string ScJDc { get; set; }
        public string ScJName { get; set; }
        public string ScJSc { get; set; }
        public bool Batched { get; set; }
        public string ScJContra { get; set; }
        public double ExchRate { get; set; }
        public string Currencycode { get; set; }
        public double Usin { get; set; }
        public double Balance { get; set; }
        public double Paid { get; set; }
        public string Sflag { get; set; }
        public string Username { get; set; }
        public bool BankCleared { get; set; }
        public DateTime? ClearingDate { get; set; }
        public DateTime? PayDue { get; set; }
        public DateTime? AwbDate { get; set; }
        public short? Fromhistory { get; set; }
        public string Mydocref { get; set; }
        public short? Jvtype { get; set; }
        public double? Newamt { get; set; }
        public DateTime? DatePosted { get; set; }
        public bool? Dontshow { get; set; }
        public double? XrateNet { get; set; }
        public double? XrateBalance { get; set; }
        public int? Batchnum { get; set; }
        public bool? Bposted { get; set; }
        public bool? Frompayroll { get; set; }
        public int? Forexentrynum { get; set; }
        public string Forexacct { get; set; }
        public int? Tillno { get; set; }
        public int? Tillsessno { get; set; }
        public int? Contrabcode { get; set; }
        public DateTime? Updatetime { get; set; }
        public bool? Revdoc { get; set; }
        public int? Companyid { get; set; }
        public string Whvat { get; set; }
        public double? Whvatamt { get; set; }
        public bool? Whvatjrn { get; set; }
        public string Neowhvat { get; set; }
        public double? Neowhvatamt { get; set; }
        public int? Gljrnnum { get; set; }
        public bool? Forexgl { get; set; }
        public int? DeptCode { get; set; }
        public double? Whvatperc { get; set; }
        public bool? Loanacct { get; set; }
        public bool? Loanalloc { get; set; }
        public bool? Noemployee { get; set; }
        public string EmpNum { get; set; }
        public string Empname { get; set; }
        public bool? Doconhold { get; set; }
        public bool? Suppcleared { get; set; }
        public DateTime? Suppclearingdate { get; set; }
        public int? Mpickno { get; set; }
        public int? Mpickbcode { get; set; }
        public int? Mpesaentryno { get; set; }
        public string Mpesatransid { get; set; }
    }
}
