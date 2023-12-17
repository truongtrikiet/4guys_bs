using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _4guys_bs.Models
{
    public class LoginView
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Mail {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string pwd {get; set;}

        [Display(Name = "Remember me?")]
        public bool rememberme {get; set;}
    }
}