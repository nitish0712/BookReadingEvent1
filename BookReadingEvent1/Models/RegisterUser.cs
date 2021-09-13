using BookReadingEvent1.Validations;
using System.ComponentModel.DataAnnotations;

namespace BookReadingEvent1.Models
{
    public class RegisterUser
    {
        [Required]
        [UserNameValidation]
        public string UserName { get; set; }
        
        [Required]
        [EmailValidation]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

    }
}