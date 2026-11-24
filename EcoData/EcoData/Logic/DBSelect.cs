using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EcoData.Logic
{
    internal class DBSelect
    {
        public static string connectionstring = @"Server=localhost;Port=3307;Database=eudata;UserID=root;pwd=;";
        
        public static void SelectInfData()
        {
            

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string query = "SELECT c.country, ROUND(AVG(e.inflation), 2) AS 'inflation' FROM countries c JOIN economics e ON e.country_id = c.id WHERE e.year BETWEEN 2011 AND 2025 GROUP BY c.country;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            decimal inflation = reader.GetDecimal(1);

                            Console.WriteLine($"{name}: {inflation}");
                        }
                    }
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static void SelectGDPData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string query = "SELECT c.country, ROUND(AVG(e.gdp_growth), 2) AS 'gdp_growth' FROM countries c JOIN economics e ON e.country_id = c.id WHERE e.year BETWEEN 2011 AND 2025 GROUP BY c.country;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            decimal gdp_growth = reader.GetDecimal(1);

                            Console.WriteLine($"{name}: {gdp_growth}");
                        }
                    }
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
