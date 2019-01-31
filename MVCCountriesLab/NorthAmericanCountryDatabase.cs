using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class NorthAmericanCountryDatabase
    {
        
        public List<Country> Countries;
        public NorthAmericanCountryDatabase()
        {
            Countries = new List<Country>();
            string[] USColors = { "Red", "White", "Blue" };
            string[] MexicoColors = { "Red", "White", "Green"};
            string[] CanadaColors = { "Red", "White", };
            Countries.Add(new Country("United States of America", "English", "Hello World!", USColors));
            Countries.Add(new Country("Mexico", "Spanish", "Hola Mundo!", MexicoColors));
            Countries.Add(new Country("Canada", "English and French", "Bonjour le monde", CanadaColors));
            Countries.Add(new Country("Belize", "English", "Hello World", USColors));
            Countries.Add(new Country("Conch Republic", "English", "Hello World", USColors));
        }
    }
}
