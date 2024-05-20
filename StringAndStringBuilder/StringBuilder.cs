using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    internal class StringBuilder
    {
        static void Main()
        {
            string s1 = "Computer";
            string s2=s1.Substring(3);
            Console.WriteLine(s2);

            string s3=s1.Substring(3,3);
            Console.WriteLine(s3);
            


        }
    }
}
