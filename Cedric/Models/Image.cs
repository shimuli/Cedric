using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int ProjectId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual Projetc Project { get; set; }
    }
}
