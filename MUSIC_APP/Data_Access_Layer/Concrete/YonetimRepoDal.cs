using Dapper;
using Entity_layer.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete
{
    public class YonetimRepoDal
    {
        public readonly IDbConnection dbconnection;


        public YonetimRepoDal()
        {
            dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU

        }


        public Admins Admin_Rol_Al(string Admin_Mail)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("@p1", Admin_Mail);
            dbconnection.Open();
            var admin_veri = dbconnection.QueryFirstOrDefault("select *from Admins where Admin_Mail=@p1");
            dbconnection.Close();
            return admin_veri;
        }

        public int AlbumSayi()
        {
            dbconnection.Open();
            int albumSayisi = dbconnection.ExecuteScalar<int>("SELECT COUNT(Album_Id) FROM Albumler");
            dbconnection.Close();
            return albumSayisi;
        }
        public int SarkiSayi()
        {
            dbconnection.Open();
            int SarkiSayisi = dbconnection.ExecuteScalar<int>("SELECT COUNT(Sarki_Id) FROM Sarkilar");
            dbconnection.Close();
            return SarkiSayisi;
        }
        public int SanatciSayi()
        {
            dbconnection.Open();
            int SanatciSayisi = dbconnection.ExecuteScalar<int>("SELECT COUNT(Sarkici_Id) FROM Sarkicilar");
            dbconnection.Close();
            return SanatciSayisi;
        }

        public string en_cok_dinlenen()
        {
            dbconnection.Open();
            string sarki = dbconnection.ExecuteScalar<string>(" SELECT TOP 1 Sarki_Ad FROM Sarkilar ORDER BY Sarki_Dinlenme_Sayi DESC");
            dbconnection.Close();
            return sarki;
        }
    }



}
