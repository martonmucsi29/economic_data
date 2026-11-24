using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoData.DTO
{
    internal class Demographics
    {
        private int year;
        private int country_id;
        private int population;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int CountryId
        {
            get { return country_id; }
            set { country_id = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value; }
        }
        public Demographics(int year, int country_id, int population)
        {
            this.year = year;
            this.country_id = country_id;
            this.population = population;
        }
    }
}
