using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    public class Patient
    {
        private readonly string _name;
        private readonly int _age;

        public Patient(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Introduce()
        {
            return $"My name is {_name} and I'm {_age} years old.";
        }

        public string Name { get { return _name; } }

        public int Age { get { return _age; } }
    }
    internal class PropertiesEx
    {
        static void Main()
        {
            Patient patient = new Patient("Manideep", 29);
            Console.WriteLine("From property==>"+patient.Name+":"+patient.Age);
        }
    }
}
