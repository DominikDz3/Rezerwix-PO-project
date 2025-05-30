using System.ComponentModel.DataAnnotations;

namespace Rezerwix.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Tytu³ wydarzenia jest wymagany.")]
        [MaxLength(100, ErrorMessage = "Tytu³ mo¿e mieæ maksymalnie 100 znaków.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Opis wydarzenia jest wymagany.")]
        [MaxLength(500, ErrorMessage = "Opis mo¿e mieæ maksymalnie 500 znaków.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Data rozpoczêcia jest wymagana.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Data zakoñczenia jest wymagana.")]
        [CustomValidation(typeof(Event), nameof(ValidateEndDate))]
        public DateTime EndDate { get; set; }

        public static ValidationResult ValidateEndDate(DateTime endDate, ValidationContext context)
        {
            var instance = context.ObjectInstance as Event;
            if (instance == null)
            {
                return new ValidationResult("Nie mo¿na zweryfikowaæ daty zakoñczenia bez instancji obiektu.");
            }
            return endDate > instance.StartDate
                ? ValidationResult.Success
                : new ValidationResult("Data koñca musi byæ póŸniejsza ni¿ data rozpoczêcia.");
        }

        [Required(ErrorMessage = "Lokalizacja jest wymagana.")]
        [MaxLength(100, ErrorMessage = "Lokalizacja mo¿e mieæ maksymalnie 100 znaków.")]
        public string Location { get; set; }

        public virtual ICollection<EventDetail> EventDetails { get; set; } = new List<EventDetail>(); // Dobra praktyka: inicjalizuj kolekcje
        public virtual ICollection<EventCategory> EventCategories { get; set; } = new List<EventCategory>(); // Dobra praktyka: inicjalizuj kolekcje
    }
}
