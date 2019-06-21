using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLogin.Models.Entity
{
    public class AppUser
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}