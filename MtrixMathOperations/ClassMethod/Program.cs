using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Dog
    {
        string breed;

        public void bark()
        {
            Console.WriteLine("Bark Bark !!");

        }

        static void Main(string[] args)
        {

            // create Dog object 
            Dog bullDog = new Dog();

            // access breed of the Dog 
            bullDog.breed = "Bull Dog";
            Console.WriteLine(bullDog.breed);

            // access method of the Dog
            bullDog.bark();

            Console.ReadLine();

        }
    }
}
