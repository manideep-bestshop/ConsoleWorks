using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class StringReverse
    {
        static void Main()
        {
            string value;
            int length;

            Console.WriteLine("enter string..");
            value = Console.ReadLine();

            length = value.Length-1;

            Console.WriteLine("reverse..");
            while (length >=0)
            {
                Console.Write("{0}", value[length]);
                length--;
            }
            Console.WriteLine();
        }
    }
}
