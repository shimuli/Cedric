using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class SubjectUnit
    {
        public int Id { get; set; }
        public string UnitsCode { get; set; }
        public string UnitsIntials { get; set; }
        public string UnitsName { get; set; }
        public string Description { get; set; }
        public int? SubjectId { get; set; }
        public bool IsActive { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
