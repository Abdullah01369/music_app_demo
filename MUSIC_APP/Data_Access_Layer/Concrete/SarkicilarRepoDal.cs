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
    public class SarkicilarRepoDal/*:GenericRepoDal<Sarkicilar>*/
    {
        public readonly IDbConnection dbconnection;
        public SarkicilarRepoDal()
        {
            dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU

        }
        public void ekle(Sarkicilar t)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Sarkici_Ad);
            dynamic.Add("@p2", t.Sarkici_Soyad);
            dynamic.Add("@p3", t.Sarkici_Dogum_Yili);
            dynamic.Add("@p4", t.Sarkici_Unvan);
            dynamic.Add("@p5", t.Sarkici_Fotograf_Yolu);


            dbconnection.Open();
            dbconnection.Execute("insert Sarkicilar(Sarkici_Ad,Sarkici_Soyad,Sarkici_Dogum_Yili,Sarkici_Unvan,Sarkici_Fotograf_Yolu) values(@p1,@p2,@p3,@p4,@p5) ", dynamic);
            dbconnection.Close();




        }
        public List<Sarkicilar> Listele()
        {
            dbconnection.Open();
            var veri = dbconnection.Query<Sarkicilar>("select *from Sarkicilar where Sarkici_Aktiflik=1 ").ToList();
            dbconnection.Close();
            return veri;
        }
        public void sil(int id,Sarkicilar t)
        {
            t.Sarkici_Id = id;
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", t.Sarkici_Id);
            d.Add("@p2", t.Sarkici_Aktiflik);
            dbconnection.Open();
            dbconnection.Execute("update Sarkicilar set Sarkici_Aktiflik=@p2  where @p1=id", d);
            dbconnection.Close();
        }
        public void guncelle(int id, Sarkicilar t)
        {
            t.Sarkici_Id = id;
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Sarkici_Ad);
            dynamic.Add("@p2", t.Sarkici_Soyad);
            dynamic.Add("@p3", t.Sarkici_Dogum_Yili);
            dynamic.Add("@p4", t.Sarkici_Unvan);
            dynamic.Add("@p5", t.Sarkici_Fotograf_Yolu);
            dynamic.Add("@p6", t.Sarkici_Id);


            dbconnection.Open();
            dbconnection.Execute("update Sarkicilar set Sarkici_Ad=@p1,Sarkici_Soyad=@p2,Sarkici_Dogum_Yili=@p3,Sarkici_Unvan=@p4,Sarkici_Fotograf_Yolu=@p5 where Sarkici_Id=@p6 ", dynamic);
            dbconnection.Close();

        }

        public String SarkiciAdiGetir(int id)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", id);
            dbconnection.Open();
            var deger = dbconnection.ExecuteScalar<string>("select Sarkici_Ad from Sarkicilar where Sarkici_Id=@p1", d).ToString();

            dbconnection.Close();
            return deger;
        }
        public String SarkicisoyAdiGetir(int id)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", id);
            dbconnection.Open();
            var deger = dbconnection.ExecuteScalar<string>("select Sarkici_Soyad from Sarkicilar where Sarkici_Id=@p1", d).ToString();

            dbconnection.Close();
            return deger;
        }

        public IEnumerable<Sarkilar> Sanatciya_Gore_Sarkilar(int id)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", id);
            dbconnection.Open();
            var veri = dbconnection.Query<Sarkilar>("select *from Sarkilar where Sarki_Sanatci_Id=@p1", dynamic);
            dbconnection.Close();
            return veri;
        }
        public IEnumerable<Sarkicilar> Sarkici_Ara(string sarkici_ad)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", sarkici_ad);
            dbconnection.Open();
            var veri = dbconnection.Query<Sarkicilar>("select *from Sarkicilar where Sarkici_Ad LIKE '%' + @p1 + '%'", d);
            dbconnection.Close();
            return veri;
        }
    }
}
