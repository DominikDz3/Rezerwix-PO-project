using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Rezerwix.Data;
using Rezerwix.Models;

namespace Rezerwix.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterAsync(string username, string password, string firstName, string lastName, DateTime dateOfBirth)
        {
            if (await _context.Users.AnyAsync(u => u.Username == username))
                return false;

            var user = new User
            {
                Username = username,
                PasswordHash = HashPassword(password),
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username);

            return user != null && user.PasswordHash == HashPassword(password);
        }

        public async Task<User?> GetUserAsync(string username)
        {
            return await _context.Users
                .Include(u => u.Reservations)
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        private static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
