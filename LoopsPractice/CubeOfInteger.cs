using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    internal class CubeOfInteger
    {
        static void Main()
        {
            int i, ctr; 

            Console.Write("Display the cube of the number:\n");  
          

            Console.Write("Input number of terms : ");  
            ctr = Convert.ToInt32(Console.ReadLine());  
            for (i = 1; i <= ctr; i++)  
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i)); 
            }
        }
    }
}
