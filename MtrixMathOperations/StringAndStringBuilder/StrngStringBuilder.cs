using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    internal class StrngStringBuilder
    {
        static void Main()
        {
            string s1 = "Computer";
            char[] ch = s1.ToCharArray();

            foreach(char c in ch)
                Console.Write(c+" ");
            Console.WriteLine();

            char[] arr = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s2=new string(arr);
            Console.WriteLine(s2);
        }
    }
}
