using MVCLogin.Models.Context;
using MVCLogin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCLogin.Controllers
{
    public class AccountController : Controller
    {
        ProjectContext db = new ProjectContext();

       
        public ActionResult UserLogin()
        {
          
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult UserLogin(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                if (db.AppUsers.Any(x=> x.Email== model.Email && x.Password == model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("AdminHomeIndex", "Home");
                }
                else
                {
                    ViewBag.Message = " Kullanıcı Adı veya Parola Yanlış..!";
                    return View();
                }

            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("UserLogin", "Account");
        }
    }
}