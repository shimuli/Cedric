using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Mpesa
    {
        public int Id { get; set; }
        public string TransactionType { get; set; }
        public string TransId { get; set; }
        public string TransTime { get; set; }
        public decimal TransAmount { get; set; }
        public string BusinessShortCode { get; set; }
        public string BillRefNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string OrgAccountBalance { get; set; }
        public string ThirdPartyTransId { get; set; }
        public string Msisdn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Kyc { get; set; }
        public DateTime Datetime { get; set; }
        public string Remarks { get; set; }
        public bool Posted { get; set; }
        public string Status { get; set; }
        public string StatusRemark { get; set; }
        public string MpesaId { get; set; }
        public decimal Commission { get; set; }
        public DateTime DateLoggedInternal { get; set; }
    }
}
