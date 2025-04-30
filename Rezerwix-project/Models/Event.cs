using Rezerwix.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rezerwix.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)] // DODANE
        public string Description { get; set; }

        public virtual ICollection<EventDetail> EventDetails { get; set; }
        public ICollection<EventCategory> EventCategories { get; set; }
    }
}
