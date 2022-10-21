using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryController
    {

       public List<Country> CountryDB { get; set; } = new List<Country>();

        public CountryController()
        {
           
            CountryDB.Add(new Country() { Name = "USA", Countries = Continent.North_America, Colors = new List<string>(){"Red", "White", "Blue" }});
            CountryDB.Add(new Country() { Name = "Sweden", Countries = Continent.Europe, Colors = new List<string>(){"Blue", "Yellow" }});
            CountryDB.Add(new Country() { Name = "Japan", Countries = Continent.Asia, Colors = new List<string>(){"Red", "White" }});
            CountryDB.Add(new Country() { Name = "Madagascar", Countries = Continent.Africa, Colors = new List<string>(){"Red", "White", "Green" }});
            CountryDB.Add(new Country() { Name = "Argentina", Countries = Continent.South_America, Colors = new List<string>(){"Blue", "White" }});
            CountryDB.Add(new Country() { Name = "Australia", Countries = Continent.Australia, Colors = new List<string>(){"Red", "White","Blue"}});
            CountryDB.Add(new Country() { Name = "New Zealand", Countries = Continent.Oceania, Colors = new List<string>(){"Red", "White", "Blue" }});
            CountryDB.Add(new Country() { Name = "Canada", Countries = Continent.North_America, Colors = new List<string>(){"Red", "White" }});


        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
            Console.ResetColor();
           
        }
        public void WelcomeAction()
        {
           bool goAgain = true;
           while (goAgain)
           {
           
             CountryListView countryList = new CountryListView(CountryDB);
             Console.ForegroundColor =ConsoleColor.Blue;
             Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list by the index number:");
             CountryListAction(countryList);
             goAgain = AskAgain();
           
           }
           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.WriteLine("Have a great day");
           Console.ResetColor();
           
        }
        public void CountryListAction(CountryListView countryList)
        {
            
            
            try
            {
                countryList.Display();
                string input = Console.ReadLine();
                int index = int.Parse(input);
                Country selectedCountry = CountryDB[index - 1];
                CountryAction(selectedCountry);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Please select a number 1-{CountryDB.Count}");
                Console.ForegroundColor = ConsoleColor.Blue;
                CountryListAction(countryList);
            }

        }
       
        
        public static bool AskAgain()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Would you like see a different country? Please enter Yes or No");
            
            string restart = Console.ReadLine().ToLower().Trim();
            if (restart == "y")
            {
                return true;
            }
            else if (restart == "n")
            {
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not a valid response");
                Console.ResetColor();
                return AskAgain();
                
            }
        }

    }
}
