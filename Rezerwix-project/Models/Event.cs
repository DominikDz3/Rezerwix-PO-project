using System.ComponentModel.DataAnnotations;

namespace Rezerwix.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Tytu� wydarzenia jest wymagany.")]
        [MaxLength(100, ErrorMessage = "Tytu� mo�e mie� maksymalnie 100 znak�w.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Opis wydarzenia jest wymagany.")]
        [MaxLength(500, ErrorMessage = "Opis mo�e mie� maksymalnie 500 znak�w.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Data rozpocz�cia jest wymagana.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Data zako�czenia jest wymagana.")]
        [CustomValidation(typeof(Event), nameof(ValidateEndDate))]
        public DateTime EndDate { get; set; }

        public static ValidationResult ValidateEndDate(DateTime endDate, ValidationContext context)
        {
            var instance = context.ObjectInstance as Event;
            if (instance == null)
            {
                return new ValidationResult("Nie mo�na zweryfikowa� daty zako�czenia bez instancji obiektu.");
            }
            return endDate > instance.StartDate
                ? ValidationResult.Success
                : new ValidationResult("Data ko�ca musi by� p�niejsza ni� data rozpocz�cia.");
        }

        [Required(ErrorMessage = "Lokalizacja jest wymagana.")]
        [MaxLength(100, ErrorMessage = "Lokalizacja mo�e mie� maksymalnie 100 znak�w.")]
        public string Location { get; set; }

        public virtual ICollection<EventDetail> EventDetails { get; set; } = new List<EventDetail>(); // Dobra praktyka: inicjalizuj kolekcje
        public virtual ICollection<EventCategory> EventCategories { get; set; } = new List<EventCategory>(); // Dobra praktyka: inicjalizuj kolekcje
    }
}
