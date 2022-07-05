using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class ClassSubject
    {
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public int? SubejctId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Subject Subejct { get; set; }
    }
}
