using Businness_Layer.Validation_Rules;
using Data_Access_Layer.Concrete.Dapper;
using Entity_Layer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class Sarkilar_Services
    {
        SarkicilarRepoDal srd = new SarkicilarRepoDal();
        Sarkilar_Validation sv = new Sarkilar_Validation();
        SarkilarRepoDal sarkilarRepoDal = new SarkilarRepoDal();

        public List<Sarkilar> listele()
        {
            return sarkilarRepoDal.Listele();
        }
        public void Ekle(Sarkilar t)
        {
            sarkilarRepoDal.Ekle(t);
        }

        public void Guncelle(int id, Sarkilar sarkilar)
        {

            sarkilarRepoDal.Guncelle(id, sarkilar);


        }
        public void Sil(Sarkilar t)
        {
            sarkilarRepoDal.Sil(t);
        }


        public IEnumerable<Sarkilar> ara_sarki(string p)
        {
            return sarkilarRepoDal.Sarki_Ara(p);
        }

        public IEnumerable<Sarkilar> Sarki_Getir_Sarkiciya_Gore(int id)
        {
            return sarkilarRepoDal.Sarkici_Sarki_getir(id);
        }

        public string sarkici_adi_getir(int id)
        {
            return srd.SarkiciAdiGetir(id);
        }

        public string sarkici_soyadi_getir(int id)
        {
            return srd.SarkicisoyAdiGetir(id);
        }
    }
}
