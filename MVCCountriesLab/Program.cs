using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {       
            
            Console.WriteLine("Welcome to fun fact Country Explorer.");
            
            CountryController cc = new CountryController();
            bool run = true;
            while (run)
            {
                cc.Contininent();
                run = Continue();
            }            
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to Continue? (y/n)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}
