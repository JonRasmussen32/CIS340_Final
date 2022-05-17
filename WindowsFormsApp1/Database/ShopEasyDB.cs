using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShopEasy
{
    public static class ShopEasyDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ShopEasy_DB.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
