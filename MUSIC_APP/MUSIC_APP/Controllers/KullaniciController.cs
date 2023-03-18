using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MUSIC_APP.Controllers
{
    public class KullaniciController : Controller
    {
        Kullanicilar_Services ks = new Kullanicilar_Services();
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login_Kullanici()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login_Kullanici(Kullanicilar k)
        {
            var user = ks.Login_Kullanici(k);  // viewden veri yakalamayı sor

            if (user!=null)
            {
                FormsAuthentication.SetAuthCookie(user.Kullanıcı_Mail,false);
                Session["Kullanıcı_Mail"] = user.Kullanıcı_Mail;
               return RedirectToAction("Index","Home");
            }
            else
            {
               return RedirectToAction("Login_Kullanici", "Kullanici");
            }
 
        }
    }
}