using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Central
{
    public partial class Trackdoc
    {
        public int Docnum { get; set; }
        public int Bcode { get; set; }
        public string Doctype { get; set; }
        public int Invtrack { get; set; }
        public int? Kahtocode { get; set; }
        public int? Crudmode { get; set; }
        public int Crudorder { get; set; }
        public int Modulecode { get; set; }
        public string Docnumber { get; set; }
        public string Cuscode { get; set; }
        public string Cusname { get; set; }
        public int? Printcopy { get; set; }
        public int? Docitems { get; set; }
        public DateTime? Saledate { get; set; }
        public TimeSpan? Saletime { get; set; }
        public string Salesmancode { get; set; }
        public string Salesmanname { get; set; }
    }
}
