using Businness_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MUSIC_APP.Controllers
{
    public class YonetimController : Controller
    {
        Album_Services album_Services = new Album_Services();
        Yonetim_Services yonetim_Services = new Yonetim_Services();

        // GET: Yonetim
        public ActionResult Index()
        {
            ViewBag.albumsayi= yonetim_Services.albumsayi();
            ViewBag.sarkicisayi= yonetim_Services.SanatciSayi();
            ViewBag.sarkisayi= yonetim_Services.SarkiSayi();
            ViewBag.encokdinlenen = yonetim_Services.en_cok_dinlenen();
            return View();
        }
        public ActionResult AlbumYonetim(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var listeara = album_Services.ara_album(p);
                return View(listeara);
            }
            else
            {
                var liste = album_Services.AlbumListesi();
                return View(liste);
            }
           
        }
    }
}