using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models.Entities
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public Account(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
