using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Demo
    {
        public void Show()
        {
            Console.WriteLine("From show no parameters");
        }
        public void Show(int n)
        {
            Console.WriteLine("From show"+ n);
        }
        public void Show(string s)
        {
            Console.WriteLine("From Show "+s);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.Show();
            demo.Show(12);
            demo.Show("manideep");
        }

    }
}
