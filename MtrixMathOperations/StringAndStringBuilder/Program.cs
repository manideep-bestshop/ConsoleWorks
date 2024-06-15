using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Computer";
            string s2 = "Computer";
            
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            string s3=s1.ToUpper();
            Console.WriteLine(s3.GetHashCode());

            string s4 = s2.ToLower();
            Console.WriteLine(s4.GetHashCode());

        }
    }
}
