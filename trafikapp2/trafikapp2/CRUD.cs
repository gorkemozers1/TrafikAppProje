using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Çağatay Gümüşel 22070370055 / Eyüp Efe Kaya 21070370062
namespace trafikapp2
{
    public class CRUD
    {
        
       public static DataTable dt;
        public static DataTable Listele(string sql)
        {
            DataTable = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, baglan, connection);
            adtr.Fill(dt);
            return dt;


        }
    }
}
