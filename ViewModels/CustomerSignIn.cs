﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_R_Us.ViewModels
{
    public class CustomerSignIn
    {
        [Required(ErrorMessage ="Username is required")]
        public string CustomerName;
        [Required(ErrorMessage ="Password is required")]
        public string Password;

        public CustomerSignIn() { }
    }
}
