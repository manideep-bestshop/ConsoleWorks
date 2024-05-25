using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialCalssMethods
{
    class Demo
    {
        public int k;
    }
    partial class Test:Demo
    {
        public int i;
        partial void Show();
    }
    partial class Test
    {
        public int j;
        partial void Show()
        {
            Console.WriteLine("From partial show method..");
        }
        public void display()
        {
            Console.WriteLine("From display");
            Show();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.i+" "+test.j+""+test.k);
            test.display();
        }
    }
}
