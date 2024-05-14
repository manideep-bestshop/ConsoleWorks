using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    internal class ActionDelegate
    {

        public static void myfun(int p, int q)
        {
            Console.WriteLine(p - q);
        }
        static void Main()
        {
            Action<int, int> val = myfun;
            val(20, 5);
        }
    }
}
