using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class Person
    {
        public string name;

        public string Name
        {
            get
            {
                return  name;
            }
            set { name = value; }
        }

        public string GetNameInLowerCase()
        {
            return Name.ToLower();
        }

        public string GetNameInUpperCase()
        {
            return Name.ToUpper();
        }
    }
    internal class UsePropertiesInsteadOfVariables
    {
        static void Main()
        {
            Person person = new Person();
            person.Name = "Mani deep";

            Console.WriteLine(person.GetNameInLowerCase());
            Console.WriteLine(person.GetNameInUpperCase());
        }
    }
}
