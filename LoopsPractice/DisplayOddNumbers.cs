using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class DisplayOddNumbers
    {
        static void Main()
        {
            int i, n, sum = 0;

            Console.Write("Display the sum of n odd natural numbers:\n");  

            Console.Write("Input number of terms : ");  
            n = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("\nThe odd numbers are :");  

            for (i = 1; i <= n; i++)  
            {
                Console.Write("{0} ", 2 * i - 1);  
                sum += 2 * i - 1;  
            }

            Console.Write("\nThe Sum of odd Natural Numbers up to {0} terms : {1} \n", n, sum); 
        }
    }
}
