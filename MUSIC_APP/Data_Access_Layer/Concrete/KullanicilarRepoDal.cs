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
    public class KullanicilarRepoDal/*:GenericRepoDal<Kullanicilar>*/
    {
        public readonly IDbConnection dbconnection;


        public KullanicilarRepoDal()
        {
            dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU

        }

        public void Kullanici_ekle(Kullanicilar t)
        {
            DynamicParameters dynamic = new DynamicParameters();

            dynamic.Add("@p1", t.Kullanıcı_Ad);
            dynamic.Add("@p2", t.Kullanıcı_Soyad);
            dynamic.Add("@p3", t.Kullanıcı_Mail);
            dynamic.Add("@p4", t.Kullanıcı_Sifre);
            dynamic.Add("@p5", t.Kullanıcı_Dogum_Yil);


            dbconnection.Open();
            dbconnection.Execute("insert Kullanicilar(Kullanıcı_Ad,Kullanıcı_Soyad,Kullanıcı_Mail,Kullanıcı_Sifre,Kullanıcı_Dogum_Yil) values(@p1,@p2,@p3,@p4,@p5) )", t);
            dbconnection.Close();




        }

        public List<Kullanicilar> Kullanici_Listele(Kullanicilar t)
        {
            dbconnection.Open();
            var veri = dbconnection.Query<Kullanicilar>("select *from Kullanicilar").ToList();
            dbconnection.Close();
            return veri;
        }
        public void sil(Kullanicilar t)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", t.Kullanici_Id);
            dbconnection.Open();
            dbconnection.Execute("delete *from Kullanicilar where Kullanici_Id=@p1", t);
            dbconnection.Close();
        }
        public void guncelle(Kullanicilar t)
        {

            DynamicParameters dynamic = new DynamicParameters();

            dynamic.Add("@p1", t.Kullanıcı_Ad);
            dynamic.Add("@p2", t.Kullanıcı_Soyad);
            dynamic.Add("@p3", t.Kullanıcı_Mail);
            dynamic.Add("@p4", t.Kullanıcı_Sifre);
            dynamic.Add("@p5", t.Kullanıcı_Dogum_Yil);
            dynamic.Add("@p6", t.Kullanici_Id);


            dbconnection.Open();
            dbconnection.Execute("update Kullanicilar  set Kullanıcı_Ad=@p1,Kullanıcı_Soyad=@p2,Kullanıcı_Mail=@p3,Kullanıcı_Sifre=@p4,Kullanıcı_Dogum_Yil=@p5 where Kullanici_Id=@p6 )", t);
            dbconnection.Close();


        }
    }
}
