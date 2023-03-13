using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MUSIC_APP.Controllers
{
    public class SarkicilarController : Controller
    {
        Sarkilar_Services Sarkilar_Services = new Sarkilar_Services();
        Sarkicilar_Services sarkicilar_Services = new Sarkicilar_Services();
        // GET: Sarkicilar
        public ActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var listeara = sarkicilar_Services.ara_sarkici(p);
                return View(listeara);
            }
            else
            {
                var liste = sarkicilar_Services.SarkiciListele();
                return View(liste);
            }

        }
        public ActionResult Sarkici_Listele_Yonetim(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var listeara = sarkicilar_Services.ara_sarkici(p);
                return View(listeara);
            }
            else
            {
                var liste = sarkicilar_Services.SarkiciListele();
                return View(liste);
            }

        }
        [HttpGet]
        public ActionResult Sarkici_Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sarkici_Ekle(Sarkicilar s)
        {
            sarkicilar_Services.SarkiciEkle(s);
            return RedirectToAction("Sarkici_Listele_Yonetim", "Sarkicilar");
        }


        [HttpGet]
        public ActionResult Sarkici_Guncelle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sarkici_Guncelle(int id, Sarkicilar s)
        {
            sarkicilar_Services.SarkiciGuncelle(id, s);
            return RedirectToAction("Sarkici_Listele_Yonetim", "Sarkicilar");
        }

        public ActionResult Sarki_Getir_Sanatciya_Gore(int id)
        {
            var veri = sarkicilar_Services.Sarkilar_Sanatciya_Gore(id);
            return View(veri);
        }

        public ActionResult Sarkici_Sil_Inactive(int id, Sarkicilar s)
        {
            ViewBag.aktif = "AKTİF";
            ViewBag.inaktif = "İNAKTİF";
            sarkicilar_Services.SarkiciSil(id, s);
            return RedirectToAction("Sarkici_Listele_Yonetim", "Sarkicilar");
        }
        public ActionResult sarki_Getir(int id)
        {
            var ad = Sarkilar_Services.sarkici_adi_getir(id);
            ViewBag.ad = ad;
            var veri = Sarkilar_Services.Sarki_Getir_Sarkiciya_Gore(id);
            return View(veri);
        }
    }
}