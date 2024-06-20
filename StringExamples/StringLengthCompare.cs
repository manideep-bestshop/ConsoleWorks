using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class StringLengthCompare
    {
        static void Main()
        {
            string str1, str2; 
            int flg = 0;
            int i = 0, l1, l2, yn = 0;

            
            Console.Write("\n\nCompare two strings whether they are equal or not:\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the 1st string: ");
            str1 = Console.ReadLine(); 

            Console.Write("Input the 2nd string: ");
            str2 = Console.ReadLine(); 

            l1 = str1.Length; 
            l2 = str2.Length; 

            if (l1 == l2)
            {
                for (i = 0; i < l1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        yn = 1;
                        i = l1; 
                    }
                }
            }

            if (l1 == l2)
                flg = 0;
            else if (l1 > l2)
                flg = 1;
            else if (l1 < l2)
                flg = -1;

            if (flg == 0)
            {
                if (yn == 0)
                    Console.Write("\nThe length of both strings are equal and both strings are same.\n\n");
                else
                    Console.Write("\nThe length of both strings are equal but they are not same.\n\n");
            }
            else if (flg == -1)
            {
                Console.Write("\nThe length of the first string is smaller than the second.\n\n");
            }
            else
            {
                Console.Write("\nThe length of the first string is greater than the second.\n\n");
            }
        }
    }
}
