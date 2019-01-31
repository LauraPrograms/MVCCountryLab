using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryDetails
    {
        Country Country;
        public CountryDetails(Country Country)
        {
            this.Country = Country;
        }
        public void Display()
        {
            Console.WriteLine("Country: " + Country.Name);
            Console.WriteLine("Language: " + Country.Language);
            Console.WriteLine("Greeting: " + Country.Hello);
            Console.WriteLine("Colors: ");
            foreach(string color in Country.Colors)
            {
                Console.WriteLine(color);
            }
        }//now we go over the teh Program.Cs to do more coding for hte controller to work
    }
}
