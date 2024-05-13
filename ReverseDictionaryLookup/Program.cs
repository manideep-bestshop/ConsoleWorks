using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDictionaryLookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dimensions = new Dictionary<string, int>
            {
                { "length", 10 },
                { "width", 20 },
                { "height", 30 }
            };

            int valueToFind = 20;

            // Brute force solution -- single key
            foreach (var item in dimensions)
            {
                if (item.Value == valueToFind)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                    break;
                }
            }

            // Brute force solution -- multiple keys
            foreach (var item in dimensions)
            {
                if (item.Value == valueToFind)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            // Using LINQ -- single key
            var key = dimensions.FirstOrDefault(x => x.Value == valueToFind).Key;
            Console.WriteLine($"{key}: {valueToFind}");

            // Using LINQ -- multiple keys
            var keys = dimensions.Where(x => x.Value == valueToFind).Select(x => x.Key);
            foreach (var k in keys)
            {
                Console.WriteLine($"{k}: {valueToFind}");
            }
        }
    }
}
