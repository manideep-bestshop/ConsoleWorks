using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityCodeWritting
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { FirstName = "Manideep", LastName = "Nampally" };
            Console.WriteLine(customer.GetFullName());
        }
    }
}
