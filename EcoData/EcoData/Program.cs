using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoData.DTO;
using EcoData.Logic;

namespace EcoData
{
    internal class Program
    {
        private static List<Economic> economics;
        private static List<Demographics> demographics;
        private static List<Country> countries;
        static void Main(string[] args)
        {
            var readCSV = new Reader();

            economics = readCSV.EcReader("CSV\\eu_economic_data.csv");
            demographics = readCSV.DeReader("CSV\\eu_demographic_data.csv");
            countries = readCSV.CoReader("CSV\\eu_countries.csv");

            //DBManager.DBConnection(economics, demographics, countries);
            Console.WriteLine("\n Összesített inflácó: ");
            DBSelect.SelectInfData();
            Console.WriteLine("\n Összesített GDP növekedett: ");
            DBSelect.SelectGDPData();
            Console.WriteLine("\n Népesség változás az elmúlt 15 évben: ");
            DBSelect.SelectPopData();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Az EU népsessége évekre lebontva: ");
            DBSelect.SelectEUPopData();
        }
    }
}
