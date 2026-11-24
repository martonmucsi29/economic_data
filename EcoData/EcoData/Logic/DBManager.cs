using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoData.DTO;

namespace EcoData.Logic
{
    internal class DBManager
    {
        public static void DBConnection(List<Economic> economics, List<Demographics> demographics)
        {
            string connectionString = @"Server=localhost;Port=3307;Database=eudata;UserID=root;pwd=;";
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {

            }
        }
    }
}
