using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _4guys_bs.Models
{
    public class RegisterView
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Mail {get; set;}

        [Required]
        [StringLength(100)]
        [DataType(DataType.Custom)]
        [Display(Name = "Username")]
        public string Usn {get; set;}

        [Required]
        [StringLength(100, ErrorMessage = "Must be at least 6 characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Psw {get; set;}

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string RePsw {get; set;}
    }
}