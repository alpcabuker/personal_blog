using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.HomePages.ToList();
            return View(deger);
        }
        public ActionResult HomePageGet(int id)
        {
            var ag = c.HomePages.Find(id);
            return View("HomePageGet", ag);
        }
        public ActionResult HomePageUpdate(HomePage x)
        {
            var ag = c.HomePages.Find(x.id);
            ag.name = x.name;
            ag.profil = x.profil;
            ag.title = x.title;
            ag.explanation = x.explanation;
            ag.communication = x.communication;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult İconList()
        {
            var deger = c.icons.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult Newİcon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Newİcon(icons p)
        {
            c.icons.Add(p);
            c.SaveChanges();
            return RedirectToAction("İconList");
        }
        public ActionResult iconGet(int id)
        {
            var ig = c.icons.Find(id);
            return View("iconGet", ig);
        }
        public ActionResult iconUpdate(icons x)
        {
            var ig = c.icons.Find(x.id);
            ig.icon = x.icon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("İconList");
        }
        public ActionResult iconDelete(int id)
        {
            var sl = c.icons.Find(id);
            c.icons.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("İconList");
        }

    }
}