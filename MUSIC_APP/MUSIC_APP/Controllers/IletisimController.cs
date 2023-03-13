using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MUSIC_APP.Controllers
{
    public class IletisimController : Controller
    {
        Iletisim_Services Iletisim_Services = new Iletisim_Services();
        // GET: Iletisim
        public ActionResult Index()
        {
            var veri = Iletisim_Services.Iletisim_Bilgi_Gonder();
            return View(veri);
        }
        public ActionResult Iletisim_Liste()
        {
            var veri = Iletisim_Services.Iletisim_Bilgi_Gonder();
            return View(veri);
        }
        [HttpGet]
        public ActionResult Guncelle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Guncelle(Iletisim p)
        {
            Iletisim_Services.iletisim_guncelle(p);

            return RedirectToAction("Iletisim_Liste", "Iletisim");
        }

        public ActionResult PartialViewIletisim()
        {
            var veri=Iletisim_Services.Iletisim_Bilgi_Gonder();

            return PartialView("iletisime_gec_partial", veri);
        }
    }
}