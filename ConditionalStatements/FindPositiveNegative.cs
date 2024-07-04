using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class FindPositiveNegative
    {
        static void Main()
        {
            int num; 
            Console.Write("Input an integer : ");  
            num = Convert.ToInt32(Console.ReadLine());  

            if (num >= 0) 
                Console.WriteLine("{0} is a positive number.\n", num); 
            else
                Console.WriteLine("{0} is a negative number. \n", num);
        }
    }
}
