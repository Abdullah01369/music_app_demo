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
    public class Oynatma_Listesi_SarkilariServices
    {
        Oynatma_Listesi_SarkilariRepoDal oynatma_Listesi_SarkilariRepoDal = new Oynatma_Listesi_SarkilariRepoDal();
        Oynatma_Listesi_Sarkilari_Validation ov = new Oynatma_Listesi_Sarkilari_Validation();
        public void OynatmaListeSarki_Kaydet(Oynatma_Listesi_Sarkilari p)
        {
            ValidationResult result = ov.Validate(p);
            if (result.IsValid)
            {
                oynatma_Listesi_SarkilariRepoDal.ekle(p);
            }


        }
        public void OynatmaListeSarki_Sil(Oynatma_Listesi_Sarkilari p)
        {
            oynatma_Listesi_SarkilariRepoDal.sil(p);
        }
        public void OynatmaListe_Guncelle(Oynatma_Listesi_Sarkilari p)
        {
            ValidationResult result = ov.Validate(p);
            if (result.IsValid)
            {
                oynatma_Listesi_SarkilariRepoDal.guncelle(p);
            }

        }
        public List<Oynatma_Listesi_Sarkilari> OynatmaListeSarki_Listele(Oynatma_Listesi_Sarkilari p)
        {
            return oynatma_Listesi_SarkilariRepoDal.Listele(p);
        }


    }
}
