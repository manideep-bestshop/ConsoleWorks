using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExamples
{
    public abstract class Company
    {

        public string name;
        public abstract string Name
        {
            get;
            set;
        }
    }

    // inheriting from abstract class
    internal class Product : Company
    {

        // provide implementation of abstract method
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
    internal class AbstractClassWithGetSet
    {
        static void Main()
        {
            Product p= new Product();
            p.Name = "Mobile";
            Console.WriteLine("Product :"+p.name);
        }
    }
}
