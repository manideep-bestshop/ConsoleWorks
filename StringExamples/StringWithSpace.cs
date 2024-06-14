using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class StringWithSpace
    {
        static void Main()
        {
            string value;
            int length = 0;

            Console.Write("Input the string: ");
            value = Console.ReadLine();

            Console.Write("The characters of the string are: ");

           
            while (length <= value.Length - 1)
            {
                Console.Write("{0} ", value[length]);
                length++; 
            }
            Console.WriteLine();
        }
    }
}
