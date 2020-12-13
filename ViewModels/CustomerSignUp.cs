using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shop_R_Us.ViewModels
{
    public class CustomerSignUp
    {
        [Required(ErrorMessage ="Username is required")]
        [MinLength (6)]
        [MaxLength (64)]
        //[UsernameValidator]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength (8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Verify password is required")]
        [Compare("Password", ErrorMessage ="Passwords must match")]
        public string Vpassword { get; set; }

        public CustomerSignUp() { }
    }
}
