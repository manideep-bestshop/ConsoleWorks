using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class SumofNnaturalNumbers
    {
        static void Main()
        {
            int i, n, sum = 0; 

            Console.Write("Display n terms of natural numbers and their sum:\n");
           
            Console.Write("Input Value of terms : ");  
            n = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("\nThe first {0} natural numbers are:\n", n); 
            for (i = 1; i <= n; i++) 
            {
                Console.Write("{0} ", i); 
                sum += i;  
            }

            Console.Write("\nThe Sum of Natural Numbers up to {0} terms : {1} \n", n, sum);
        }
    }
}
