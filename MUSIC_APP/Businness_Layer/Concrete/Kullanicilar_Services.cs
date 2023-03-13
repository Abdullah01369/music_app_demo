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
    public class Kullanicilar_Services
    {
        KullanicilarRepoDal krd = new KullanicilarRepoDal();
        Kullanici_Validation kv = new Kullanici_Validation();
        public void Kullanici_Kaydet(Kullanicilar k)
        {
            ValidationResult result = kv.Validate(k);
            if (result.IsValid)
            {
                krd.Kullanici_ekle(k);
            }

        }
        public void Kullanici_Sil(Kullanicilar k)
        {
            krd.sil(k);
        }

        public List<Kullanicilar> Kullanici_Listele(Kullanicilar k)
        {
            return krd.Kullanici_Listele(k);
        }

        public void Kullanici_Guncelle(Kullanicilar k)
        {
            ValidationResult result = kv.Validate(k);
            if (result.IsValid)
            {
                krd.guncelle(k);
            }

        }
    }
}
