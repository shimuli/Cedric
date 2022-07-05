using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Cashbookcustomer
    {
        public int Rptdocnum { get; set; }
        public int Rptbcode { get; set; }
        public DateTime? Rptdocdate { get; set; }
        public string Cuscode { get; set; }
        public string Cusname { get; set; }
        public string Myperiod { get; set; }
        public double Rptcuramount { get; set; }
        public string Rptcurcode { get; set; }
        public string Rptcurname { get; set; }
        public double Rptcurexchrate { get; set; }
        public double Rpttotal { get; set; }
        public double? Cashtotal { get; set; }
        public double? Chequetotal { get; set; }
        public double? Credtotal { get; set; }
        public double? Mpesatotal { get; set; }
        public double? Rtgtotal { get; set; }
        public double? Tttotal { get; set; }
        public string Matchtype { get; set; }
        public double? Matchtotal { get; set; }
        public string Rptbranch { get; set; }
        public int Modulecode { get; set; }
        public int? Rptdeptcode { get; set; }
        public string Rptdeptname { get; set; }
        public int? Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
        public string Docpaymode { get; set; }
        public string Docref { get; set; }
        public string Towncode { get; set; }
        public string Townname { get; set; }
        public string Routecode { get; set; }
        public string Routename { get; set; }
        public string Credcontcode { get; set; }
        public string Credcontname { get; set; }
        public string Cashbookid { get; set; }
        public string Cashbookname { get; set; }
        public string Doctype { get; set; }
        public string Doctypename { get; set; }
        public string Doctnarration { get; set; }
        public string Matchdocnumber { get; set; }
    }
}
