using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class SalesJournalDetail
    {
        public string CusCode { get; set; }
        public string CusDesc { get; set; }
        public int SaleinvNum { get; set; }
        public DateTime SaleinvDate { get; set; }
        public string InvCode { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Totalcost { get; set; }
        public string Description { get; set; }
        public double Taxvalue { get; set; }
        public short SalesMonth { get; set; }
        public int SalesYear { get; set; }
        public int InStock { get; set; }
    }
}
