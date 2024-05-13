using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary1 = new Dictionary<string, string> { { "Superman", "Flight" } };
            Dictionary<string, string> dictionary2 = new Dictionary<string, string> { { "Batman", "Gadgets" } };

            // Using LINQ
            var merged = dictionary1.Concat(dictionary2).ToDictionary(x => x.Key, x => x.Value);

            // Using a foreach loop
            foreach (var item in dictionary2)
            {
                dictionary1[item.Key] = item.Value;
            }

            // Using the Union extension method
            var merged2 = dictionary1.Union(dictionary2).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
