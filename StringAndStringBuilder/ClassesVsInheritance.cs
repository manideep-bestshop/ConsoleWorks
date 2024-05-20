using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class B1
    {
        public int i = 19;
        public void Show()
        {
            Console.WriteLine("From show of B1..");
        }
    }
    class D1 : B1
    {
        public int j = 28;
        public void Display()
        {
            Console.WriteLine("From display D1..");
        }
    }
    internal class ClassesVsInheritance
    {
        static void Main()
        {
            D1 d = new D1();
            B1 b = d; //implicit casting

            Console.WriteLine(b is D1);
            Console.WriteLine(b.i);

            b.Show();
        }
    }
}
