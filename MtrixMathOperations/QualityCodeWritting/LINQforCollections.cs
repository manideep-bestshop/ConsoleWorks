using System;
using System.Collections.Generic;
using System.Linq;

namespace QualityCodeWritting
{
    public class Customer1
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class LINQforCollections
    {
        static void Main()
        {
            List<Customer1> customers = new List<Customer1>
        {
            new Customer1 { Name = "Alice", Age = 30 },
            new Customer1 { Name = "Bob", Age = 25 },
            new Customer1 { Name = "Charlie", Age = 35 }
        };

            var adults = customers.Where(c => c.Age >= 30).ToList();

            foreach (var customer in adults)
            {
                Console.WriteLine($"{customer.Name} is an adult.");
            }
        }
    }
}
