using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcHomework.Models;

namespace MvcHomework.Controllers
{
    public class AdminController : Controller
    {
        RehberEntities db = new RehberEntities();
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            var liste = db.Kisi.ToList();
            return View(liste);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kisi kisi)
        {
            db.Kisi.Add(kisi);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Index2()
        {
            var liste = db.Kisi.ToList();
            return View(liste);
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var kisi = db.Kisi.FirstOrDefault(p => p.ID == ID);
            return View(kisi);
        }
        [HttpPost]
        public ActionResult Edit(Kisi kisi)
        {
            db.Entry(kisi).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var kisi = db.Kisi.FirstOrDefault(p => p.ID == ID);
            return View(kisi);
        }
        [HttpPost]
        public ActionResult Delete(Kisi kisi)
        {
            db.Entry(kisi).State = EntityState.Modified;
            db.Kisi.Remove(kisi);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}