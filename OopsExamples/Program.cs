using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    public class Person
    {
        private readonly string _name;
        private readonly int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Introduce()
        {
            return $"My name is {_name} and I'm {_age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Manideep",29);
            Console.WriteLine(person.Introduce());
        }
    }
}
