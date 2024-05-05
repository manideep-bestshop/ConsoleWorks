using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> heroesAbilities = new Dictionary<string, string>
            {
                 { "Flash", "Super Speed" },
                 {  "Green Lantern", "Power Ring" },
                 { "Aquaman", "Atlantean Strength" }
            };

            // Inverting the dictionary using LINQ
            var inverted = heroesAbilities.ToDictionary(x => x.Value, x => x.Key);

            // Inverting the dictionary using a foreach loop
            Dictionary<string, string> inverted2 = new Dictionary<string, string>();
            foreach (var item in heroesAbilities)
            {
                inverted2[item.Value] = item.Key;
            }
        }
    }
}
