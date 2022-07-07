using System.ComponentModel.DataAnnotations;

namespace Burger.Web.Controllers.DTOs
{
    public class LoginDTO
    {
        [Required]
        [MinLength(5, ErrorMessage = "Email Alani En Az 5 Karakter Olmalidir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
