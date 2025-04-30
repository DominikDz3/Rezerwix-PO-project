using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Rezerwix.Models;

namespace Rezerwix.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string PasswordHash { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
