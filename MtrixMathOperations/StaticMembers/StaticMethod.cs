using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class Fruits
    {
        public static int Apples = 65;
        public static void NumberOfApples()
        {
            Console.WriteLine("Total Apples :"+Apples);
        }
    }
    internal class StaticMethod
    {
        static void Main()
        {
            Fruits.NumberOfApples();
            Console.WriteLine("using class:"+Fruits.Apples);
        }
    }
}
