using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models.Data
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


    }
}
