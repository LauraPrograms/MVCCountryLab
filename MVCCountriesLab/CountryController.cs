using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryController
    {
        //goal is to do the calling views, calling mdata, logic, then the menu(), details(country) view.
        public void CountryDetails(Country c)//First create this. then the object country
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();//we checked to see if this works before buildingthe databases for the country lists and a menu that lets us select a country
        }
        public void Contininent()
        {
            Console.WriteLine("What conitinent would you like to learn about? Please type in North America or South America");
            string input = Console.ReadLine();
            List<Country> countries = new List<Country>();
            if (input.ToLower() == "north america")
            {
                NorthAmericanCountryDatabase nadb = new NorthAmericanCountryDatabase();
                countries = nadb.Countries;

            }
            else if (input.ToLower()=="south america")
            {
                SouthAmericanCountryDatabase sadb = new SouthAmericanCountryDatabase();
                countries = sadb.Countries;
            }
            if (countries.Count() == 0)
            {
                Console.WriteLine("Bless your heart, sweetie, I did not understand that.");
            }
            else
            {
                int index = CountryMenu.DisplayCountries(countries);
                Country chosenCountry = countries[index];
                CountryDetails cd = new CountryDetails(chosenCountry);
                cd.Display();
            }
        }
    }
}
