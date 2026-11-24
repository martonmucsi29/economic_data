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

                DateTime year;
                decimal gdp_growth;
                decimal inflation;

                while(!sr.EndOfStream)
                {
                    var sor = sr.ReadLine();
                    string[] bontott_sor = sor.Split(',');

                    try
                    {
                        year = DateTime.Parse(bontott_sor[0]);
                        gdp_growth = decimal.Parse(bontott_sor[3]);
                        inflation = decimal.Parse(bontott_sor[4]);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    Economic ecoData = new Economic(year, bontott_sor[1], gdp_growth, inflation);
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

                DateTime year;
                int population;

                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine();
                    string[] bontott_sor = sor.Split(',');

                    try
                    {
                        year = DateTime.Parse(bontott_sor[0]);
                        population = int.Parse(bontott_sor[2]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    Demographics ecoData = new Demographics(year, bontott_sor[1], population);
                    demographics.Add(ecoData);
                }
                return demographics;
            }
        }
    }
}
