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
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public DateTime StartDate { get; set; }

        [Required]
        [MaxLength(100)]
        [CustomValidation(typeof(Event), "ValidateEndDate")]
        public DateTime EndDate { get; set; }
        public static ValidationResult ValidateEndDate(DateTime endDate, ValidationContext context)
        {
            var instance = context.ObjectInstance as Event;
            return endDate > instance?.StartDate
                ? ValidationResult.Success
                : new ValidationResult("Data koñca musi byæ póŸniejsza ni¿ data rozpoczêcia");
        }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; }

        public virtual ICollection<EventDetail> EventDetails { get; set; }
        public ICollection<EventCategory> EventCategories { get; set; }
    }
}
