using MvcHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHomework.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string ara)
        {
            RehberEntities db = new RehberEntities();
            var liste = db.Kisi.ToList();
            if (ara != null)
            {
                return View(liste.Where(p => p.AD.Contains(ara)));
            }
            return View(liste);
        }
    }
}