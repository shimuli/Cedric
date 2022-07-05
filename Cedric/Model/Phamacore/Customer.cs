﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Customer
    {
        public int CategoryCode { get; set; }
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public string Physicaladd { get; set; }
        public string CreditCode { get; set; }
        public double Creditlimit { get; set; }
        public DateTime? Lastrptdate { get; set; }
        public double? Lastrptamount { get; set; }
        public bool? Blocked { get; set; }
        public double Balance { get; set; }
        public string Contact { get; set; }
        public int? TownCode { get; set; }
        public string CusCode0 { get; set; }
        public string Companyfax { get; set; }
        public string Email { get; set; }
        public bool? TemporaryCustomer { get; set; }
        public double Unapplied { get; set; }
        public double Used { get; set; }
        public double Using { get; set; }
        public string Oldaccount { get; set; }
        public double UnappliedBalance { get; set; }
        public double TotalSales { get; set; }
        public double StatementCurrentbal { get; set; }
        public double Overapplied { get; set; }
        public double Used2 { get; set; }
        public double Using2 { get; set; }
        public double OverAppliedBalance { get; set; }
        public string Fax { get; set; }
        public string Currencycode { get; set; }
        public int? Paytermcode { get; set; }
        public bool? Creddiscounts { get; set; }
        public bool? PrintStatement { get; set; }
        public bool? EnforceTerms { get; set; }
        public double TempCreditlimit { get; set; }
        public string Pin { get; set; }
        public string Vat { get; set; }
        public double? Thisperiod { get; set; }
        public double? Thirtydays { get; set; }
        public double? Sixtydays { get; set; }
        public double? Ninetydays { get; set; }
        public double? Onetwenty { get; set; }
        public string CscatgCode { get; set; }
        public bool? Xblocked { get; set; }
        public double? Openingbal { get; set; }
        public double? Pdcheques { get; set; }
        public bool? Branchdata { get; set; }
        public string Cusmemberno { get; set; }
        public int? Cuspoints { get; set; }
        public int? Redeemed { get; set; }
        public bool? Choose { get; set; }
        public int? Routecode { get; set; }
        public bool? Forcemember { get; set; }
        public bool? Defcashinvoice { get; set; }
        public int? Credccode { get; set; }
        public bool? Nonregistered { get; set; }
        public double? Customermargin { get; set; }
        public bool? Noalloc { get; set; }
        public bool? Defcustominvoice { get; set; }
        public double? Xdaybalance { get; set; }
        public bool? Issmart { get; set; }
        public string Sce { get; set; }
        public string Smscontact { get; set; }
        public string Smscontactname { get; set; }
        public string Cellname { get; set; }
        public string Cellnumber { get; set; }
        public string Cellcountry { get; set; }
        public int? Bcode { get; set; }
        public bool? Salebelowmin { get; set; }
        public bool? Salebelowlcost { get; set; }
        public string Salebelowminlastset { get; set; }
        public bool? Forcesmart { get; set; }
        public bool? Memberlimittrack { get; set; }
        public int? Memberlimitdaymonth { get; set; }
        public double? Memberlimitamt { get; set; }
        public bool? Memberlimitsaleperc { get; set; }
        public bool? Memberlimitcumulate { get; set; }
        public bool? Membercopayexcess { get; set; }
        public bool? Membercopayvoucher { get; set; }
        public double? Memberlimitdayamt { get; set; }
        public double? Memberlimitmonthamt { get; set; }
        public double? Memberlimitpercamt { get; set; }
        public bool? Attachanymemberonsale { get; set; }
        public int? Memberlimitmonthstart { get; set; }
        public int? Memberlimitmonthend { get; set; }
        public bool? Membercorpcashexists { get; set; }
        public bool? IgnoreMemberCopayLimitSettings { get; set; }
        public string Cusbcodelist { get; set; }
        public string Cusbcodenamelist { get; set; }
        public bool? Issmartcopay { get; set; }
        public double? Issmartbalancecash { get; set; }
        public double? Copayperc { get; set; }
        public byte[] Cbrow { get; set; }
    }
}
