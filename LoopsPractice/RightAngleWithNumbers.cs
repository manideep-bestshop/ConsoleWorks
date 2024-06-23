using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class RightAngleWithNumbers
    {
        static void Main()
        {
            int i, j, rows; 
            Console.Write("Display the pattern as a right-angle triangle using numbers:\n"); 
            
            Console.Write("Input number of rows : "); 
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)  
            {
                for (j = 1; j <= i; j++)  
                {
                    Console.Write("{0}", j);    
                }
                   Console.Write("\n"); 
            }
        }
    }
}
