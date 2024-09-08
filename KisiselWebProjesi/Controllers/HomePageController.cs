using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.HomePages.ToList();
            return View(deger);
        }
        public PartialViewResult icons()
        {
            var deger = c.icons.ToList();
            return PartialView(deger);
        }
          
    }
}