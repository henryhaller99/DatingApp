using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Age { get; set; }
    }
}