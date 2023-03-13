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
    public class Oynatma_ListeleriServices
    {
        Oynatma_ListeleriRepoDal oynatma_ListeleriRepoDal = new Oynatma_ListeleriRepoDal();
        Oynatma_Listeleri_Validation olv = new Oynatma_Listeleri_Validation();

        public void OynatmaListe_Kaydet(Oynatma_Listeleri p)
        {
            ValidationResult result = olv.Validate(p);
            if (result.IsValid)
            {
                oynatma_ListeleriRepoDal.ekle(p);
            }


        }
        public void OynatmaListe_Sil(Oynatma_Listeleri p)
        {
            oynatma_ListeleriRepoDal.sil(p);
        }
        public void OynatmaListe_Guncelle(Oynatma_Listeleri p)
        {
            ValidationResult result = olv.Validate(p);
            if (result.IsValid)
            {
                oynatma_ListeleriRepoDal.guncelle(p);
            }

        }
        public List<Oynatma_Listeleri> OynatmaListe_Listele(Oynatma_Listeleri p)
        {
            return oynatma_ListeleriRepoDal.Listele(p);
        }

    }
}
