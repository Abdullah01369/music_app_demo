using Businness_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MUSIC_APP.Controllers
{
    public class AboutController : Controller
    {
        About_Services about_Services = new About_Services();
        // GET: About
        public ActionResult Index()
        {
            var veri=about_Services.listele();
            return View(veri);
        }
        public ActionResult gorsel()
        {
            return View();
        }
    }
}