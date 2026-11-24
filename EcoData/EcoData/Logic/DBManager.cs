using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoData.DTO;
using MySql.Data.MySqlClient;

namespace EcoData.Logic
{
    internal class DBManager
    {
        public static void DBConnection(List<Economic> economics, List<Demographics> demographics, List<Country> countries)
        {
            string connectionString = @"Server=localhost;Port=3307;Database=eudata;UserID=root;pwd=;";
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string createQuery = @"CREATE TABLE IF NOT EXISTS countries ( id INT PRIMARY KEY, country VARCHAR(50) NOT NULL); CREATE TABLE IF NOT EXISTS demographics (year INT NOT NULL, country_id INT NOT NULL, population INT NOT NULL, FOREIGN KEY (country_id) REFERENCES countries(id)); CREATE TABLE IF NOT EXISTS economics (year INT NOT NULL, country_id INT NOT NULL, gdp_growth DECIMAL(5,2), inflation DECIMAL(5,2), FOREIGN KEY (country_id) REFERENCES countries(id));";

                using(MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = createQuery;
                    cmd.ExecuteNonQuery();
                }
                
                foreach(var country in countries)
                {
                    string query = "INSERT INTO countries(id, country) VALUES (@id, @country)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", country.Id);
                        command.Parameters.AddWithValue("@country", country.CountryName);

                        command.ExecuteNonQuery();
                    }
                }
                foreach(var eco in economics)
                {
                    string query = "INSERT INTO economics(year, country_id, gdp_growth, inflation) VALUES (@year, @country_id, @gdp_growth, @inflation)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@year", eco.Year);
                        command.Parameters.AddWithValue("@country_id", eco.CountryId);
                        command.Parameters.AddWithValue("@gdp_growth", eco.Gdp_growth);
                        command.Parameters.AddWithValue("@inflation", eco.Inflation);

                        command.ExecuteNonQuery();
                    }
                }
                foreach(var demo in demographics)
                {
                    string query = "INSERT INTO demographics(year, country_id, population) VALUES (@year, @country_id, @population)";

                    using(MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@year", demo.Year);
                        command.Parameters.AddWithValue("@country_id", demo.CountryId);
                        command.Parameters.AddWithValue("@population", demo.Population);

                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
    }
}
