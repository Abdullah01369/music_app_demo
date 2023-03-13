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

namespace Data_Access_Layer.Concrete
{
    public class Iletisim_RepoDal
    {
        public readonly IDbConnection dbconnection;
        public Iletisim_RepoDal()
        {

            {
                dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU
            }
        }

        public List<Iletisim> Iletisim_Gonder()
        {
            dbconnection.Open();
            var veri = dbconnection.Query<Iletisim>("select * from Iletisim").ToList();
            dbconnection.Close();
            return veri;
        }

        public void Güncelle(Iletisim i)
        {
           
            DynamicParameters d = new DynamicParameters();
            d.Add("@p1", i.Iletisim_Mail);
            d.Add("@p2", i.Iletisim_Tel);
            d.Add("@p3", i.Iletisim_Adres);
           


           
            dbconnection.Open();
            dbconnection.Execute("update Iletisim set Iletisim_Mail=@p1,Iletisim_Tel=@p2,Iletisim_Adres =@p3 where Iletisim_Id=1 ", d);
            dbconnection.Close();
        }
    }
}
