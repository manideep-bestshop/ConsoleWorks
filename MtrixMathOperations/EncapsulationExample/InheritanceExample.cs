using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
   
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }
    internal class InheritanceExample
    {
        static void Main()
        {
            var dog = new Dog();
            dog.Name = "Buddy";
            dog.Eat();
            dog.Bark();
        }
    }
}
