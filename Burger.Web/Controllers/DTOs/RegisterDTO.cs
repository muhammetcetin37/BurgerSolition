using System.ComponentModel.DataAnnotations;

namespace Burger.Web.Models.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Ad { get; set; }


        [Required]
        public string Soyad { get; set; }


        [Required]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        public bool IAgree { get; set; }


    }
}