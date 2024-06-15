using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    internal class CountTheNumberOfWords
    {
        static void Main()
        {
            string str;
            int l, wrd; 

            Console.Write("\n\nCount the total number of words in a string:\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string: ");
            str = Console.ReadLine(); 

            l = 0; 
            wrd = 1;
            Console.WriteLine(str.Length);

            while (l <= str.Length - 1)
            {
               
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++; 
                }

                l++;
            }

             Console.Write("Total number of words in the string is: {0}\n", wrd);
        }
    }
}
