using Dapper;

using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.Dapper
{
    public class AlbumlerRepoDal
    {
        public readonly IDbConnection dbconnection;
        public AlbumlerRepoDal()
        {

            {
                dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU
            }
        }

        public List<Albumler> Arama(Albumler t)
        {
            throw new NotImplementedException();
        }

        public void Ekle(Albumler t)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Album_Ad);
            dynamic.Add("@p2", t.Album_Cikis_Yil);
            dynamic.Add("@p3", t.Album_Sanatci_Id);


            dbconnection.Open();
            dbconnection.Execute("insert Albumler (Album_Ad,Album_Cikis_Yil,Album_Sanatci_Id) values(@p1,@p2,@p3) ", dynamic);
            dbconnection.Close();


        }

        public void Guncelle(int id, Albumler t) // model parametresi verdim diye adreste çağırmana gerek yok, çalışıyor...
        {

            t.Album_Id = id;
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Album_Ad);
            dynamic.Add("@p2", t.Album_Cikis_Yil);
            dynamic.Add("@p3", t.Album_Sanatci_Id);
            dynamic.Add("@p4", t.Album_Id);


            dbconnection.Open();
            dbconnection.Execute("update Albumler set Album_Ad=@p1,Album_Cikis_Yil=@p2,Album_Sanatci_Id=@p3 where Album_Id=@p4 ", dynamic);
            dbconnection.Close();
        }

        public Albumler IdBul(int id, Albumler t)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Album_Id);
            dbconnection.Open();
            dbconnection.Execute("select *from Albumler where @Album_Id=@p1");
            dbconnection.Close();
            return t; /// HATA ALMAMAK İÇİN KOYULDU


        }

        public List<Albumler> Listele()
        {
            dbconnection.Open();
            var deger = dbconnection.Query<Albumler>("select *from Albumler").ToList();
            dbconnection.Close();
            return deger;


        }

        public void Sil(Albumler t)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Album_Id);
            dbconnection.Open();
            dbconnection.Execute("delete Albumler Album_Id=@p1 ", t);
            dbconnection.Close();
        }
        public List<Sarkilar> Albume_Gore_Sarkilar(int id)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@p1", id);
            dbconnection.Open();

            List<Sarkilar> deger = dbconnection.Query<Sarkilar>("select * from Sarkilar where Sarkı_Album_Id = @p1", dynamicParameters).ToList();
            dbconnection.Close();
            return deger;
        }

        public string Album_Adi_Gonder(int id)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@p1", id);
            dbconnection.Open();

            var deger = dbconnection.Query<Albumler>("select  Album_Ad from Albumler where Album_Id = @p1", dynamicParameters).ToString();
            dbconnection.Close();
            return deger;

        }


        public IEnumerable<Albumler> Album_Ara(string album_ad)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", album_ad);
            dbconnection.Open();
            var veri = dbconnection.Query<Albumler>("select *from Albumler where Album_Ad LIKE '%' + @p1 + '%'", d);
            dbconnection.Close();
            return veri;
        }


    }
}
