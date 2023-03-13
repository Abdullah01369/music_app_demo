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
    public class SarkilarRepoDal
    {
        public readonly IDbConnection dbconnection;


        public SarkilarRepoDal()
        {
            dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU

        }
       

        public void Ekle(Sarkilar t)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Sarki_Ad);
            dynamic.Add("@p2", t.Sarki_Cikis_Yılı);
            dynamic.Add("@p3", t.Sarki_Sanatci_Id);
            dynamic.Add("@p4", t.Sarkı_Album_Id);


            dbconnection.Open();
            dbconnection.Execute("insert Sarkilar(Sarki_Ad,Sarki_Cikis_Yılı,Sarki_Sanatci_Id,Sarkı_Album_Id) values(@p1,@p2,@p3,@p4) ", dynamic);
            dbconnection.Close();
        }

        public void Guncelle(int id, Sarkilar t)
        {

            t.Sarki_Id = id;
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Sarki_Ad);
            dynamic.Add("@p2", t.Sarki_Cikis_Yılı);
            dynamic.Add("@p3", t.Sarki_Id);
            dynamic.Add("@p4", t.Sarki_Sanatci_Id);



            dbconnection.Open();
            dbconnection.Execute("update Sarkilar  set Sarki_Ad=@p1 ,Sarki_Cikis_Yılı=@p2,Sarki_Sanatci_Id=@p4 WHERE Sarki_Id=@p3 ", dynamic);
            dbconnection.Close();
        }

       

        public List<Sarkilar> Listele()
        {
            dbconnection.Open();
            var deger = dbconnection.Query<Sarkilar>("select *from Sarkilar").ToList();
            dbconnection.Close();
            return deger;
        }

        public void Sil(Sarkilar t)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", t.Sarki_Id);
            dbconnection.Open();
            dbconnection.Execute("delete Sarkilar Sarki_Id=@p1 )", t);
            dbconnection.Close();
        }

        public IEnumerable<Sarkilar> Sarki_Ara(string sarki_ad)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", sarki_ad);
            dbconnection.Open();
            var veri = dbconnection.Query<Sarkilar>("select *from Sarkilar where Sarki_Ad LIKE '%' + @p1 + '%'", d);
            dbconnection.Close();
            return veri;
        }

        public IEnumerable<Sarkilar> Sarkici_Sarki_getir(int id)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@p1", id);
            dbconnection.Open();
            var veri = dbconnection.Query<Sarkilar>("select *from Sarkilar where  Sarki_Sanatci_Id=@p1", dynamic);
            dbconnection.Close();
            return veri;
        }
    }
}
