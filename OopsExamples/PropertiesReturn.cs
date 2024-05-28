using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    public class Customer
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _age;

        public Customer(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public string Introduce()
        {
            return $"My name is {Name} and I'm {_age} years old.";
        }

        public string Name { get { return $"{_firstName} {_lastName}"; } }

        public int Age { get { return _age; } }
    }
    internal class PropertiesReturn
    {
       static void Main()
        {
            Customer customer = new Customer("Mani","Deep",29);
            Console.WriteLine(customer.Introduce());
            Console.WriteLine(customer.Name);
        }
    }
}
