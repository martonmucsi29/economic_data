using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoData.DTO
{
    internal class Economic
    {
        private int year;
        private int country_id;
        private decimal gdp_growth;
        private decimal inflation;

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
        public decimal Gdp_growth
        {
            get { return gdp_growth; }
            set { gdp_growth = value; }
        }
        public decimal Inflation
        {
            get { return inflation; }
            set { inflation = value; }
        }
        public Economic(int year, int country_id, decimal gdp_growth, decimal inflation)
        {
            this.year = year;
            this.country_id = country_id;
            this.gdp_growth = gdp_growth;
            this.inflation = inflation;
        }
    }
}
