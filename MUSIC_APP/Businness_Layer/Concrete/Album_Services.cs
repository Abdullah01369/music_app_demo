using Businness_Layer.Validation_Rules;
using Data_Access_Layer.Concrete.Dapper;
using Entity_Layer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class Album_Services
    {
        Albumler_Validation validationRules = new Albumler_Validation();
        AlbumlerRepoDal albumlerRepoDal = new AlbumlerRepoDal();



        public List<Albumler> AlbumListesi()
        {   
            var liste = albumlerRepoDal.Listele();
            return liste;
        }




        public void Albüm_Ekle(Albumler p)
        {
              albumlerRepoDal.Ekle(p);
      
        }
        public void Guncelle(int id, Albumler t)
        {
            
            
                albumlerRepoDal.Guncelle(id,  t);

        }
        public void Sil(Albumler p)
        {
            albumlerRepoDal.Sil(p);
        }

        public List<Sarkilar> Albume_Gore_Sarkilar(int id)
        {
            return albumlerRepoDal.Albume_Gore_Sarkilar(id);
        }
        public string Albume_Adi_AL(int id)
        {
            return albumlerRepoDal.Album_Adi_Gonder(id);
        }

        public IEnumerable<Albumler> ara_album(string p) 
        {
            return albumlerRepoDal.Album_Ara(p);
        }


    }
}
