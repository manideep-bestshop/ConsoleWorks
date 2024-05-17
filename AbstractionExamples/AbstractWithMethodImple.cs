using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExamples
{
    abstract class Animal
    {
        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("Sleeping..");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    internal class AbstractWithMethodImple
    {
        static void Main()
        {
            Pig myPig=new Pig();
            myPig.animalSound();
            myPig.sleep();
        }
    }
}
