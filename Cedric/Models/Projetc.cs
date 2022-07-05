using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models
{
    public partial class Projetc
    {
        public Projetc()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Stack { get; set; }
        public string Client { get; set; }
        public string Category { get; set; }
        public string ProjectUrl { get; set; }
        public int? Viewers { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? ViewerDate { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
