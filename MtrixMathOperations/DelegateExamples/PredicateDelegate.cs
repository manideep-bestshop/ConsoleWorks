using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    internal class PredicateDelegate
    {
        public delegate bool my_delegate(string mystring);

        public static bool myfun(string mystring)
        {
            if (mystring.Length < 7)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        static void Main()
        {
            my_delegate obj = myfun;
            Console.WriteLine(obj("Good Morning"));
        }
    }
}
