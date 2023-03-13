using Data_Access_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
  public  class About_Services
    {
        About_RepoDal aboutRepoDal = new About_RepoDal();

        public List<About> listele()
        {
            return aboutRepoDal.Listele();
        }
    }
}
