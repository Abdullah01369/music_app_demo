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
    public class Sarkicilar_Services
    {
        SarkicilarRepoDal srd = new SarkicilarRepoDal();
        Sarkici_Validation sv = new Sarkici_Validation();
        public void SarkiciEkle(Sarkicilar s)
        {
            ValidationResult result = sv.Validate(s);

            if (result.IsValid)
            {
                srd.ekle(s);
            }

        }

        public void SarkiciSil(int id,Sarkicilar s)
        {
            srd.sil(id,s);
        }

        public void SarkiciGuncelle(int id, Sarkicilar s)
        {
            ValidationResult result = sv.Validate(s);

            if (result.IsValid)
            {
                srd.guncelle(id, s);
            }

        }

        public List<Sarkicilar> SarkiciListele()
        {
            return srd.Listele();
        }
        public string IdyeGoreSarkici(int id)
        {
            return srd.SarkiciAdiGetir(id);
        }

        public IEnumerable<Sarkilar> Sarkilar_Sanatciya_Gore(int id)
        {

            return srd.Sanatciya_Gore_Sarkilar(id);
        }
        public IEnumerable<Sarkicilar> ara_sarkici(string ad)
        {

            return srd.Sarkici_Ara(ad);
        }
    }
}
