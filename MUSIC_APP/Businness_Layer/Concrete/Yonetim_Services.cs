using Data_Access_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class Yonetim_Services
    {
        YonetimRepoDal yrd = new YonetimRepoDal();

        public int albumsayi()
        {
            return yrd.AlbumSayi();
        }

        public int SarkiSayi()
        {
            return yrd.SarkiSayi();
        }
        public int SanatciSayi()
        {
            return yrd.SanatciSayi();
        }
        public string en_cok_dinlenen() 
        {
            return yrd.en_cok_dinlenen().ToUpper();
        }
    }
}
