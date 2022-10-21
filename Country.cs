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
    internal class Country
    {
    public string Name { get; set; }
    public Continent Countries { get; set; }
    public List<string> Colors { get; set; } = new List<string>();
    
    }

    public enum Continent
    {
      Europe,
      Asia,
      Africa,
      North_America,
      South_America,
      Australia,
      Oceania
    }
    
}