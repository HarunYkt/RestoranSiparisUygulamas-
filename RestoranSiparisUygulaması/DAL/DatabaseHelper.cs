using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranSiparisUygulaması.DAL
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=RestoranDB;Uid=root;Pwd=localhost;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
