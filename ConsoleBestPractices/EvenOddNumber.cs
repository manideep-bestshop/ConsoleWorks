using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    internal class EvenOddNumber
    {
        static bool IsEvenNumber(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            int n;
            Console.Write("Enter an integer : ");
            n = Int32.Parse(Console.ReadLine());

            if (IsEvenNumber(n))
            {
                Console.WriteLine("{0} is even", n);
            }
            else
            {
                Console.WriteLine("{0} is odd", n);
            }

            Console.ReadKey();
        }
    }
}
