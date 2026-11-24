using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoData.DTO;

namespace EcoData.Logic
{
    internal class Reader
    {
        public List<Economic> EcReader (string ecPath)
        {
            List<Economic> economics = new List<Economic>();

            using(StreamReader  sr = new StreamReader(ecPath))
            {
                sr.ReadLine();

                int year;
                int country_id;
                decimal gdp_growth;
                decimal inflation;

                while(!sr.EndOfStream)
                {
                    var sor = sr.ReadLine();
                    string[] bontott_sor = sor.Split(',');

                    try
                    {
                        year = int.Parse(bontott_sor[0]);
                        country_id = int.Parse(bontott_sor[1]);
                        gdp_growth = decimal.Parse(bontott_sor[2].Replace('.', ','));
                        inflation = decimal.Parse(bontott_sor[3].Replace('.', ','));
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    Economic ecoData = new Economic(year, country_id, gdp_growth, inflation);
                    economics.Add(ecoData);
                }
                return economics;
            }
        }
        public List<Demographics> DeReader(string dePath)
        {
            List<Demographics> demographics = new List<Demographics>();

            using (StreamReader sr = new StreamReader(dePath))
            {
                sr.ReadLine();

                int year;
                int country_id;
                int population;

                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine();
                    string[] bontott_sor = sor.Split(',');

                    try
                    {
                        year = int.Parse(bontott_sor[0]);
                        country_id = int.Parse(bontott_sor[1]);
                        population = int.Parse(bontott_sor[2]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    Demographics ecoData = new Demographics(year, country_id, population);
                    demographics.Add(ecoData);
                }
                return demographics;
            }
        }
        public List<Country> CoReader(string coPath)
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(coPath))
            {
                sr.ReadLine();

                int id;

                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine();
                    string[] bontott_sor = sor.Split(',');

                    try
                    {
                        id = int.Parse(bontott_sor[0]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    Country countryData = new Country(id, bontott_sor[1]);
                    countries.Add(countryData);
                }
                return countries;
            }
        }
    }
}
