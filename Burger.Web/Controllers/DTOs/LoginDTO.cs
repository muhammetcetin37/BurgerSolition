﻿using System.ComponentModel.DataAnnotations;

namespace Burger.Web.Models.DTOs
{
    public class LoginDTO
    {

        [Required]
        [MinLength(5, ErrorMessage = "Email Alani en az 5 karakter olmalidir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}