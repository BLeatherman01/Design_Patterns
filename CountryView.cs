using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
     class CountryView
    {
       
        public Country DisplayCountry { get; set; }

        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }
    
    
        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Countries);

            foreach (string color in DisplayCountry.Colors)
            {
               
               Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
              
               Console.WriteLine(color);
               
            }
            
            
        }
    
    }
}
