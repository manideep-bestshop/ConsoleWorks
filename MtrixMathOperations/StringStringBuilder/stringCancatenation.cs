using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStringBuilder
{
    internal class stringCancatenation
    {
        static void Main()
        {
            string result = "";

            for (int i = 0; i < 10; i++)
            {
                result += i + " ";
            }

            Console.WriteLine("Numbers: " + result);
        }
    }
}
