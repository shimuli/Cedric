using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class ClassStream
    {
        public ClassStream()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Bcode { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
