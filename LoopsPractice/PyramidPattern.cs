using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class PyramidPattern
    {
        static void Main()
        {
            int i, j, spc, rows, k, t = 1; 

           
            Console.Write("Display the pattern like a pyramid with numbers increased by 1:\n");
            

            Console.Write("Input number of rows : ");  
            rows = Convert.ToInt32(Console.ReadLine());     

            spc = rows + 4 - 1; 
            for (i = 1; i <= rows; i++) 
            {
                for (k = spc; k >= 1; k--)  
                {
                    Console.Write(" ");  
                }
                for (j = 1; j <= i; j++) 
                {
                    Console.Write("{0} ", t++);  
                }
                Console.Write("\n");  
                spc--;  
            }
        }
    }
}
