using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLogin.Models.VM
{
    public class LoginVM
    {
        [
            EmailAddress(ErrorMessage = "E-posta formatında giriş yapınız..!"),
            Required(ErrorMessage ="E-posta giriniz..!"),
            DisplayName("E-posta")
        ]

        public string Email { get; set; }

        [
         
          Required(ErrorMessage = "Parola giriniz!"),
          DisplayName("Parola")
        ]

        public string Password { get; set; }

    }
}