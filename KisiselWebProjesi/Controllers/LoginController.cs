using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KisiselWebProjesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.username == ad.username && x.password == ad.password);
            if (bilgiler != null)

            {

                FormsAuthentication.SetAuthCookie(bilgiler.username, false);
                Session["username"] = bilgiler.username.ToString();
                return RedirectToAction("Index", "Admin");

            }

            else
            {
                return View();
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }
    }
}