using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class CountryMenu
    {
        public static int DisplayCountries(List<Country> countries)
        {
            int index = 0;
            bool run = true;
            while (run)
            {
                Console.WriteLine("Type the number of the country you would like to know more about.");
                int i = 1;
                foreach (Country country in countries)
                {
                    Console.WriteLine(i + "." + country.Name);
                    i++;
                }
                try
                {
                    index = int.Parse(Console.ReadLine()) - 1;
                    if (index >= 1 && index <= countries.Count())
                    {
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a valid number");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            return index;
        }
    }
}
