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
    public class Oynatma_ListeleriRepoDal/*:GenericRepoDal<Oynatma_Listeleri>*/
    {
        public readonly IDbConnection dbconnection;


        public Oynatma_ListeleriRepoDal()
        {
            dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU

        }

        public void ekle(Oynatma_Listeleri t)
        {
            DynamicParameters dynamic = new DynamicParameters();

            dynamic.Add("@p1", t.Oynatma_Liste_Ad);




            dbconnection.Open();
            dbconnection.Execute("insert Oynatma_Listeleri(Oynatma_Liste_Ad) values(@p1) )", t);
            dbconnection.Close();




        }

        public List<Oynatma_Listeleri> Listele(Oynatma_Listeleri t)
        {
            dbconnection.Open();
            var veri = dbconnection.Query<Oynatma_Listeleri>("select *from Oynatma_Listeleri").ToList();
            dbconnection.Close();
            return veri;
        }
        public void sil(Oynatma_Listeleri t)
        {
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", t.Oynatma_Liste_Id);
            dbconnection.Open();
            dbconnection.Execute("delete *from Oynatma_Listeleri where Liste_Id=@p1", t);
            dbconnection.Close();
        }
        public void guncelle(Oynatma_Listeleri t)
        {

            DynamicParameters dynamic = new DynamicParameters();

            dynamic.Add("@p1", t.Oynatma_Liste_Ad);
            dynamic.Add("@p2", t.Oynatma_Liste_Id);




            dbconnection.Open();
            dbconnection.Execute("update Oynatma_Listeleri set Oynatma_Liste_Ad=@p1 where Liste_Id=@p2 )", t);
            dbconnection.Close();


        }
    }
}
