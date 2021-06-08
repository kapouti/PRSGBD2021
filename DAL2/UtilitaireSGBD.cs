using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class UtilitaireSGBD
    {
        static public IDbConnection GetConnection()
        {
            //SEULE ligne qui dépend du SGBDR utilisé (ici Sql Server)
            return new SqlConnection(@"Data Source=DESKTOP-VQFENLG\SQLEXPRESS;Initial Catalog = PRSGBD2021;Integrated Security=True");
        }
        public static SqlConnection ObtenirConnexion()
        {
            return new SqlConnection(@"Data Source=DESKTOP-VQFENLG\SQLEXPRESS;Initial Catalog = PRSGBD2021;Integrated Security=True");
        }
    }
}
