using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoData.DTO
{
    internal class Economic
    {
        private DateTime year;
        private string country;
        private decimal gdp_growth;
        private decimal inflation;

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
        public Economic(DateTime year, string country, decimal gdp_growth, decimal inflation)
        {
            this.year = year;
            this.country = country;
            this.gdp_growth = gdp_growth;
            this.inflation = inflation;
        }
    }
}
