using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(30, MinimumLength  = 8, ErrorMessage = "Username Length must be between 8 and 30")]
        public string Username { get; set; }

        [Required]
        [StringLength(30, MinimumLength  = 8, ErrorMessage = "Password Length must be between 8 and 30")]
        public string Password { get; set; }
    }
}