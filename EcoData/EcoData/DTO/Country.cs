using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoData.DTO
{
    internal class Country
    {
        private int id;
        private string country;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string CountryName
        {
            get { return country; }
            set { country = value; }
        }
        public Country(int id, string country)
        {
            this.id = id;
            this.country = country;
        }
    }
}
