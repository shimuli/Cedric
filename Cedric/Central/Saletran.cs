using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Saletran
    {
        public string Docnumber { get; set; }
        public DateTime Saledate { get; set; }
        public TimeSpan? Saletime { get; set; }
        public string Myperiod { get; set; }
        public string Cuscode { get; set; }
        public string Cusname { get; set; }
        public double? Docamt { get; set; }
        public string Itmcode { get; set; }
        public string Itmname { get; set; }
        public double? Itmpack { get; set; }
        public double? Qtysoldpw { get; set; }
        public double? Qtysold { get; set; }
        public string Pw { get; set; }
        public double Itmprice { get; set; }
        public double? Itmtotalinc { get; set; }
        public double Itmtax { get; set; }
        public double Itmtotalcost { get; set; }
        public double? Itmtotalexc { get; set; }
        public double? Goodscost { get; set; }
        public string SalesmanCode { get; set; }
        public string Salesman { get; set; }
        public string Salesbranch { get; set; }
        public int Docnum { get; set; }
        public int Salesdocdetnum { get; set; }
        public int Salesbcode { get; set; }
        public int Modulecode { get; set; }
        public string Invoicetypename { get; set; }
        public int? Invoicetype { get; set; }
        public double? Stockpw { get; set; }
        public int? Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
        public string Towncode { get; set; }
        public string Townname { get; set; }
        public string Routecode { get; set; }
        public string Routename { get; set; }
        public string Credcontcode { get; set; }
        public string Credcontname { get; set; }
        public string Docref { get; set; }
        public double? Docvat { get; set; }
        public double? Doctotalexc { get; set; }
        public string Docuser { get; set; }
        public string Memberno { get; set; }
        public double? Mempointsbuy { get; set; }
        public double? Mempointsredeem { get; set; }
    }
}
