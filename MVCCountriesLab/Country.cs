using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class Country
    { //we only need the constructors here.  Then we make theCountryDetails class
        public string Name;
        public string Language;
        public string Hello;
        public string[] Colors;

        public Country(string Name, string Language, string Hello, string [] Colors)
        {
            this.Name = Name;
            this.Language = Language;
            this.Hello = Hello;
            this.Colors = Colors;
        }
    }
}
