using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult AdminHomeIndex()
        {
            return View();
        }
    }
}