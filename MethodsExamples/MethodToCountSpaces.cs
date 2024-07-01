using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    internal class MethodToCountSpaces
    {
        public static int SpaceCount(string str)
        {
            int spcctr = 0;
            string str1;

            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);

                if (str1 == " ")
                    spcctr++;
            }

            return spcctr; 
        }
        public static void Main()
        {
            string str2;

            Console.Write("Please input a string : ");
            str2 = Console.ReadLine();

            Console.WriteLine(SpaceCount(str2));
        }
    }
}
