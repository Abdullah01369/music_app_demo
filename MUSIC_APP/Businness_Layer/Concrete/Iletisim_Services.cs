using Data_Access_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
   public class Iletisim_Services
    {
        Iletisim_RepoDal Iletisim_Repo = new Iletisim_RepoDal();
        public List<Iletisim> Iletisim_Bilgi_Gonder()
        {
            return Iletisim_Repo.Iletisim_Gonder();
            
        }
        public void iletisim_guncelle(Iletisim p) 
        {
            Iletisim_Repo.Güncelle(p);
        }
    }
}
