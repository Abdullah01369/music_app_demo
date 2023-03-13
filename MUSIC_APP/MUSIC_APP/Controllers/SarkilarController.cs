using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MUSIC_APP.Controllers
{
    public class SarkilarController : Controller
    {  // classların vaildasyonlarına bak 
       // GET: Sarkilar

        Sarkilar_Services sarkilar_Services = new Sarkilar_Services();

        public ActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var listeara = sarkilar_Services.ara_sarki(p);
                return View(listeara);
            }
            else
            {
                var liste = sarkilar_Services.listele();
                return View(liste);
            }


        }



        #region ekleme
        [HttpGet]
        public ActionResult Sarki_Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sarki_Ekle(Sarkilar s)
        {
            sarkilar_Services.Ekle(s);
            return RedirectToAction("Sarkilar/SarkiListe");
        }
        #endregion



        #region guncelle
        [HttpGet]
        public ActionResult Sarki_Guncelle()  //ÇALIŞMIYOR
        {

            return View();
        }
        [HttpPost]
        public ActionResult Sarki_Guncelle(int id, Sarkilar s)
        {
            sarkilar_Services.Guncelle(id, s);
            return RedirectToAction("Index", "Albumler");
        }
        #endregion


        public ActionResult Sarki_Listele(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                var listeara = sarkilar_Services.ara_sarki(p);
                return View(listeara);
            }
            else
            {
                var liste = sarkilar_Services.listele();
                return View(liste);
            }

        }

        public string ad_soyad_getir(int id)
        {
            string ad = sarkilar_Services.sarkici_adi_getir(id);
            string soyad = sarkilar_Services.sarkici_soyadi_getir(id);
            string ad_soyad = ad + " " + soyad;
            return ad_soyad;
        }
    }
}