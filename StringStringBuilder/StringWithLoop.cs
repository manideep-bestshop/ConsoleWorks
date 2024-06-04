using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStringBuilder
{
    internal class StringWithLoop
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.Append(i);
                sb.Append(" ");
            }

            Console.WriteLine("Numbers: " + sb.ToString());
        }
    }
}
