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
    public class Oynatma_Listesi_SarkilariRepoDal/*:GenericRepoDal<Oynatma_Listesi_Sarkilari>*/
    {
        public readonly IDbConnection dbconnection;


        public Oynatma_Listesi_SarkilariRepoDal()
        {
            dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU

        }

        public void ekle(Oynatma_Listesi_Sarkilari t)
        {
            DynamicParameters dynamic = new DynamicParameters();

            dynamic.Add("@p1", t.Liste_OL_Id);
            dynamic.Add("@p2", t.Liste_Sarki_ID);



            dbconnection.Open();
            dbconnection.Execute("insert Oynatma_Listesi_Sarkilari(Liste_OL_Id,Liste_Sarki_ID) values(@p1,@p2) )", t);
            dbconnection.Close();




        }

        public List<Oynatma_Listesi_Sarkilari> Listele(Oynatma_Listesi_Sarkilari t)
        {
            dbconnection.Open();
            var veri = dbconnection.Query<Oynatma_Listesi_Sarkilari>("select *from Oynatma_Listesi_Sarkilari").ToList();
            dbconnection.Close();
            return veri;
        }
        public void sil(Oynatma_Listesi_Sarkilari t)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", t.Liste_Id);
            dbconnection.Open();
            dbconnection.Execute("delete *from Oynatma_Listesi_Sarkilari where Liste_Id=@p1", t);
            dbconnection.Close();
        }
        public void guncelle(Oynatma_Listesi_Sarkilari t)
        {

            DynamicParameters dynamic = new DynamicParameters();

            dynamic.Add("@p1", t.Liste_OL_Id);
            dynamic.Add("@p2", t.Liste_Sarki_ID);
            dynamic.Add("@p3", t.Liste_Id);



            dbconnection.Open();
            dbconnection.Execute("update Oynatma_Listesi_Sarkilari set Liste_OL_Id=@p1,Liste_Sarki_ID=@p2 where Liste_Id=@p3 )", t);
            dbconnection.Close();


        }
    }
}
