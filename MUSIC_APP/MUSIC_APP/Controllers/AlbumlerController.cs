using Businness_Layer.Concrete;
using Businness_Layer.Validation_Rules;
using Data_Access_Layer.Concrete.Dapper;
using Entity_Layer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MUSIC_APP.Controllers
{
    public class AlbumlerController : Controller
    {
        //şarkı dinleme
        //hakkımızda
        //

       
        Album_Services album_Services = new Album_Services();

        // GET: Albumler
        public ActionResult Index(string p)
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

        public ActionResult Sarkilari_Albume_Gore_Goster(int id)
        {
            //  ViewBag.albumadi= album_Services.Albume_Adi_AL(id);
            var veri = album_Services.Albume_Gore_Sarkilar(id);
            return View(veri);
        }

        public ActionResult Album_Sarki_Islem(int id)
        {
            var veri = album_Services.Albume_Gore_Sarkilar(id);
            return View(veri);
        }





        [HttpGet]
        public ActionResult Album_Ekle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Album_Ekle(Albumler albumler)
        {
            Albumler_Validation cv = new Albumler_Validation();
            ValidationResult result = cv.Validate(albumler);
            if (result.IsValid)
            {

                album_Services.Albüm_Ekle(albumler);
                return RedirectToAction("AlbumYonetim", "Yonetim");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View();
        }


        [HttpGet]
        public ActionResult Album_Guncelle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Album_Guncelle(int id, Albumler t)
        {
            album_Services.Guncelle(id, t);
            return RedirectToAction("AlbumYonetim", "Yonetim");
        }
    }

}