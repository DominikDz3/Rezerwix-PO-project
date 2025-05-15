using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Rezerwix.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Nazwa u�ytkownika jest wymagana")]
        [MaxLength(50, ErrorMessage = "Maksymalnie 50 znak�w")]
        public string Username { get; set; }

        [Required]
        public string Role { get; set; }

        [Required(ErrorMessage = "Has�o jest wymagane")]
        [MaxLength(100, ErrorMessage = "Maksymalnie 100 znak�w")]
        public string PasswordHash { get; set; }

        [Required]
        public string Salt { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [EmailAddress(ErrorMessage = "Niepoprawny format email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Imi� jest wymagane")]
        [MaxLength(50, ErrorMessage = "Maksymalnie 50 znak�w")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [MaxLength(50, ErrorMessage = "Maksymalnie 50 znak�w")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Data urodzenia jest wymagana")]
        public DateTime DateOfBirth { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}