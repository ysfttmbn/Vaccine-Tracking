using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VaksinApp.Models;

namespace VaksinApp.Controllers
{
    public class AkunController : Controller
    {
        AppEntity db = new AppEntity();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Akun akun)
        {
            using (AppEntity context = new AppEntity())
            {
                bool IsValidUser = context.Akuns.Any(x => x.username.ToLower() ==
                     akun.username.ToLower() && x.password == akun.password);
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(akun.username, false);
                    Response.Write("<script>alert('Anda Login Sebagai')</script>");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    Response.Write("<script>alert('Username atau Pasword anda salah!!')</script>");
                }
                return View();
            }

        }
    }
}