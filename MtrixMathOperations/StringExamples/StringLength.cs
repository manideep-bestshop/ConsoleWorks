using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class StringLength
    {
        static void Main()
        {
            int length = 0;
            Console.WriteLine("Enter string value:");
            string value=Console.ReadLine();
            foreach(char c in value)
            {
                length += 1;
            }
            Console.WriteLine("Length of string : "+length);
        }
    }
}
