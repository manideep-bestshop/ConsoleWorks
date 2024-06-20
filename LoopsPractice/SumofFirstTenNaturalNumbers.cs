using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class SumofFirstTenNaturalNumbers
    {
        static void Main()
        {
            int j, sum = 0; 

            Console.Write("Find the sum of the first 10 natural numbers:\n");
            Console.Write("The first 10 natural numbers are:\n");

            for (j = 1; j <= 10; j++) 
            {
                sum = sum + j; 
                Console.Write("{0} ", j); 
            }

            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}
