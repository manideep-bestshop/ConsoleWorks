using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class RightAnglePattern
    {
        static void Main()
        {
            int i, j, rows;  
   
            Console.Write("Display the pattern like a right angle :\n");  
            

            Console.Write("Input number of rows : "); 
            rows = Convert.ToInt32(Console.ReadLine()); 

            for (i = 1; i <= rows; i++) 
            {
                for (j = 1; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.Write("\n");  
            }
        }
    }
}
