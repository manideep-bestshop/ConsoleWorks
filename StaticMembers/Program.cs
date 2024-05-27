using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{

    public class Cat
    {

        public Cat()
        {
            instances++;
        }

        public static void HowManyCats()
        {
            Console.WriteLine("{0} cats adopted",
                  instances);
        }
        private static int instances = 0;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat.HowManyCats();
            Cat frisky = new Cat();
            Cat.HowManyCats();
            Cat whiskers = new Cat();
            Cat.HowManyCats();
        }
    }
}
