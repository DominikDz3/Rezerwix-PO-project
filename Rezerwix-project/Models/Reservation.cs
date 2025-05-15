using System.ComponentModel.DataAnnotations;

namespace Rezerwix.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Range(1, 10)]
        public int NumberOfTickets { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int EventDetailId { get; set; }
        public EventDetail EventDetail { get; set; }
    }
}