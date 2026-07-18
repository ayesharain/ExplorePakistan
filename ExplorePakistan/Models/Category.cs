using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExplorePakistan.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Icon { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }

        public Category()
        {
            Destinations = new HashSet<Destination>();
        }
    }
}