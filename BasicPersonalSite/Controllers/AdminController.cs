using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicPersonalSite.Models.Concrete;
using Microsoft.Ajax.Utilities;

namespace BasicPersonalSite.Controllers
{
    public class AdminController : Controller
    {

        SkillContext skillContext = new SkillContext();
        public ActionResult Index()
        {
            
            var skills = skillContext.Yeteneks.ToList();
            return View(skills);
        }

        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(Yetenek yetenek)
        {
            skillContext.Yeteneks.Add(yetenek);
            skillContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var entityToDelete = skillContext.Yeteneks.Find(id);
            skillContext.Yeteneks.Remove(entityToDelete);
            skillContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateSkill(int id)
        {
            var entityToUpdate =skillContext.Yeteneks.Find(id);
            return View("UpdateSkill", entityToUpdate);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Yetenek yetenek)
        {
            var entityToUpdate = skillContext.Yeteneks.Find(yetenek.Id);
            entityToUpdate.Deger = yetenek.Deger;
            entityToUpdate.Aciklama = yetenek.Aciklama;
            skillContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}