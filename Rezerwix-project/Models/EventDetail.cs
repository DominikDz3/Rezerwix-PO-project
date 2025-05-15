using System.ComponentModel.DataAnnotations;

namespace Rezerwix.Models
{
    public class EventDetail
    {
        public int EventDetailId { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Liczba miejsc nie mo¿e byæ ujemna.")]
        public int AvailableSeats { get; set; }

        public bool IsSeatAvailable => AvailableSeats > 0;

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}