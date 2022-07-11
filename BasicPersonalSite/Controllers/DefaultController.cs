using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicPersonalSite.Models.Concrete;

namespace BasicPersonalSite.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {   
            SkillContext skillContext = new SkillContext();
            var skills = skillContext.Yeteneks.ToList();
            return View(skills);
        }
    }
}