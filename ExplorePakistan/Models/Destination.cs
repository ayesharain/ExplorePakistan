using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ExplorePakistan.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Province { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name = "Best Time to Visit")]
        public string BestTimeToVisit { get; set; }

        [Display(Name = "Things to Do")]
        public string ThingsToDo { get; set; }

        [Display(Name = "How to Reach")]
        public string HowToReach { get; set; }

        [Display(Name = "Featured")]
        public bool IsFeatured { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        // Foreign Key
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        [NotMapped]
        public double AverageRating
        {
            get
            {
                if (Reviews != null && Reviews.Any())
                    return Reviews.Average(r => r.Rating);
                return 0;
            }
        }

        public Destination()
        {
            Reviews = new HashSet<Review>();
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
    }
}