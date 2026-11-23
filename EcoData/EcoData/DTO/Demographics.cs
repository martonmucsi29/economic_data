using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoData.DTO
{
    internal class Demographics
    {
        private DateTime year;
        private string country;
        private int population;

        public DateTime Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value; }
        }
        public Demographics(DateTime year, string country, int population)
        {
            this.year = year;
            this.country = country;
            this.population = population;
        }
    }
}
