using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    internal class CustomDelegate
    {
        public delegate int my_delegate(int s, int d,
                                 int f, int g);
        public static int mymethod(int s, int d,
                                  int f, int g)
        {
            return s * d * f * g;
        }
        static void Main()
        {
            my_delegate obj = mymethod;
            Console.WriteLine(obj(12, 34, 35, 34));
        }
    }
}
