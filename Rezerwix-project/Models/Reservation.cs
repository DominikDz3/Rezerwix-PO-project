namespace Rezerwix.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        // Relacja z User
        public int UserId { get; set; }
        public User User { get; set; }

        // Relacja z EventDetail (DODANE)
        public int EventDetailId { get; set; }
        public EventDetail EventDetail { get; set; }
    }
}