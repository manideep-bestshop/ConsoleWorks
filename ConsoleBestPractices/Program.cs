using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    internal class Program
    {
        static void SetValues(int x)
        {
            x += 10;
        }

        static void SetValues(ref int x)
        {
            x += 10;
        }
        static void Main(string[] args)
        {
            int i = 5;
            SetValues(i);

            System.Console.WriteLine("Currently i = " + i);  //call by value

            SetValues(ref i);
            Console.WriteLine("Currently i = " + i);  // call by ref


        }
    }
}
