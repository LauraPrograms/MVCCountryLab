using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{

    class SouthAmericanCountryDatabase
    {
        public List<Country> Countries;
        public SouthAmericanCountryDatabase()
        {
            Countries = new List<Country>();
            string[] ArgentinaColors = { "Light Blue", "White"};
            string[] UruguayColors = { "Blue", "White" };
            string[] ArubaColors = { "Light Blue", "Yellow", "White", "Red" };
            string[] ColombiaColors = { "Yellow", "Blue", "Red" };
            string[] EcuadorColors = { "Yellow", "Blue", "Red", "Sky Blue", "Green", "Grey", "Silver", "Gold" };
            Countries.Add(new Country("Argentina", "Spanish", "Hola Mundo!", ArgentinaColors));
            Countries.Add(new Country("Uruguay", "Spanish", "Hola Mundo!", UruguayColors));
            Countries.Add(new Country("Ecuador", "Spanish", "Hola Mundo!", EcuadorColors));
            Countries.Add(new Country("Aruba", "Dutch and Papiamento", "Hallo Wereld, Halo Mundu", ArubaColors));
            Countries.Add(new Country("Colombia", "Spanish and English", "Hola Mundo, Hello World", ColombiaColors));
        }
    }
}
