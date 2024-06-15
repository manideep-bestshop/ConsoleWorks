using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class NumberOfWords
    {
        static void Main()
        {
            string value; 
            int length, word; 

            Console.Write("Input the string: ");
            value = Console.ReadLine(); 

            length = 0; 
            word = 1; 

            while (length <= value.Length - 1)
            {
                
                if (value[length] == ' ' || value[length] == '\n' || value[length] == '\t')
                {
                }

                length++;
            }

            Console.Write("Total number of words in the string is: {0}\n", word);
        }
    }
}
