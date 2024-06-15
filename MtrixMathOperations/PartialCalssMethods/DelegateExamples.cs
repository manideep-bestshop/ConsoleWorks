using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialCalssMethods
{
    internal class DelegateExamples
    {
        delegate void Test(string name);
        static void Main()
        {
            Display("Manideep");
        }
        public static void Display(string name)
        {
            Console.WriteLine(name);
        }
    }
}
