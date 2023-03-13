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
   public class About_RepoDal
    {
        public readonly IDbConnection dbconnection;
        public About_RepoDal()
        {

            {
                dbconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbaglanti"].ToString()); // BAGLANTI OLUSTURULDU
            }
        }
        public List<About> Listele()
        {  
            dbconnection.Open();
            var deger = dbconnection.Query<About>("select *from About").ToList();
            dbconnection.Close();
            return deger;
        }
    }
}
